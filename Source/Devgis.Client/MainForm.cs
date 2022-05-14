using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devgis.Controls;
using Devgis.Common;
using Devgis.Client.Forms;
using System.Threading;
using Telerik.WinControls.UI;
using MySql.Data.MySqlClient;

namespace Devgis.Client
{
    public partial class MainForm : BaseWindow
    {
        Thread twork = null;
        public MainForm()
        {
            InitializeComponent();
            twork = new Thread(RefreshEquipment);
            twork.Start();
        }

        #region 事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            //上班签到
            PublicDim.StartWork();

            //初始化配置信息配音信息
            try
            {
                PublicDim.configInfo = SerializeHelper.DeSerialize<ConfigClass>(PublicDim.ConfigFileName);
            }
            catch
            { }

            //默认初始化
            if (PublicDim.configInfo == null)
            {
                PublicDim.configInfo = new ConfigClass();
                PublicDim.configInfo.Music1Path = System.IO.Path.Combine(Application.StartupPath, "default.mp3");
                PublicDim.configInfo.Music2Path = System.IO.Path.Combine(Application.StartupPath, "default.mp3");
                PublicDim.configInfo.Music3Path = System.IO.Path.Combine(Application.StartupPath, "default.mp3");
                PublicDim.configInfo.Music4Path = System.IO.Path.Combine(Application.StartupPath, "default.mp3");
            }
            
            

            //初始化信息
            lbOperator.Text = "当前用户：" + PublicDim.RealName;

            //初始化停车数量信息
            GetParkingInfo();

            //加载视频画面初始化信息
            GetSentryBoxInfo();

            //加载设备连接信息
            GetEquipInfo();

            GetFeeType(); //
        }

        private void timerWork_Tick(object sender, EventArgs e)
        {
            //刷新停车场剩余车位等
            GetParkingInfo();

            //刷新设备状态信息

        }

        /// <summary>
        /// 退出时释放资源
        /// </summary>
        /// <param name="e"></param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            if (twork != null)
            {
                try
                {
                    twork.Abort();
                    twork.Join();
                }
                catch
                { }
            }
        }
        #endregion

        #region 私有方法
        //收费信息相关字段
        bool hasRule = false; //默认没有收费规则
        double starthour=0;
        double startmonyhour=0;
        double endmonyhour=0;
        double maxmoney=0;

        /// <summary>
        /// 获取收费信息 
        /// </summary>
        private void GetFeeType()
        {
            string sql = string.Format("select * from t_chargerule where parkingid ='{0}'", PublicDim.ParkingID);
            try
            {
                DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
                if (dt == null || dt.Rows.Count < 0)
                {
                    hasRule = false;
                }
                else
                {
                    hasRule = true;
                    try
                    {
                        starthour = Convert.ToDouble(dt.Rows[0]["starthour"]);
                    }
                    catch
                    { }
                    try
                    {
                        startmonyhour = Convert.ToDouble(dt.Rows[0]["startmonyhour"]);
                    }
                    catch
                    { }

                    try
                    {
                        endmonyhour = Convert.ToDouble(dt.Rows[0]["endmonyhour"]);
                    }
                    catch
                    { }
                    try
                    {
                        maxmoney = Convert.ToDouble(dt.Rows[0]["maxmoney"]);
                    }
                    catch
                    { }
                }
            }
            catch
            {
                hasRule = false;
            }
        }

        /// <summary>
        /// 获取时间
        /// </summary>
        /// <param name="Startime"></param>
        /// <param name="EndTime"></param>
        /// <returns></returns>
        private double GetFee(DateTime Startime, DateTime EndTime)
        {
            if (hasRule)
            {
                TimeSpan ts = EndTime - Startime;
                double hour = ts.TotalHours;
                double Amount = 0;
                if (hour > starthour)
                {
                    Amount = starthour * startmonyhour + (hour - starthour) * endmonyhour; //超过起始时间
                }
                else
                {
                    Amount = hour * startmonyhour; //时间内
                }
                if (maxmoney > 0)
                {
                    if (Amount > maxmoney)
                    {
                        Amount = maxmoney;
                    }
                }
                return Amount; //返回金额
            }
            else
            {
                return -1;//没有规则
            }
        }

        /// <summary>
        /// 刷新设备信息
        /// </summary>
        private void RefreshEquipment()
        {
            while (true)
            {
                //刷新设备
                if (rgvEquipment.IsHandleCreated)
                {
                    rgvEquipment.Invoke((EventHandler)(delegate
                    {
                        foreach (GridViewRowInfo row in rgvEquipment.Rows)
                        {
                            if (row.Cells["colInfo"].Value != null && !string.IsNullOrEmpty(row.Cells["colInfo"].Value.ToString()))
                            {
                                row.Cells["colState"].Value = PublicDim.GetEquipState(row.Cells["colInfo"].Value.ToString());
                            }
                        }
                    }));
                }
                
                

                Thread.Sleep(5000); //5秒刷新一次
            }
        }

        /// <summary>
        /// 获取停车位信息
        /// </summary>
        private void GetParkingInfo()
        {
            string sql = string.Format("select * from v_parkingcount where parkingid='{0}'", PublicDim.ParkingID);
            int Total = 0; //总数量er
            int Reserved = 0; //保留车位
            int Parkinged = 0; //已使用车位
            int Left = 0; //剩余车位
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    switch (dr["title"].ToString())
                    {
                        case "total":
                            try
                            {
                                Total = Convert.ToInt32(dr["counts"]);
                            }
                            catch
                            { }
                            break;
                        case "parkinged":
                            try
                            {
                                Parkinged = Convert.ToInt32(dr["counts"]);
                            }
                            catch
                            { }
                            break;
                        case "reserved":
                            try
                            {
                                Reserved = Convert.ToInt32(dr["counts"]);
                            }
                            catch
                            { }
                            break;
                    }
                }
                Left = Total - Reserved - Parkinged;
                if (Left < 0)
                {
                    Left = 0;
                }
            }
            lbCounts.Text = string.Format("{0}停车场 共{1}停车位 在场车位{2} 预定车辆{3} 剩余{4}停车位"
                ,PublicDim.ParkingName,Total,Parkinged,Reserved,Left);
        }

        #region 私有
        string EnterInfo=string.Empty; //入口控制信息
        string OutInfo=string.Empty; //出口控制信息

        string Video1 = string.Empty; //视频1
        string Video2 = string.Empty;//视频2
        string Video3 = string.Empty;//视频3
        string Video4 = string.Empty;//视频4
        #endregion

        /// <summary>
        ///  获取岗亭设备 视频等信息
        /// </summary>
        private void GetSentryBoxInfo()
        {
            string sql = string.Format("select * from t_sentrybox where id='{0}'", PublicDim.SentryBoxID);
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                EnterInfo = (dt.Rows[0]["enterinfo"] == null ? string.Empty : dt.Rows[0]["enterinfo"].ToString()); //入口控制信息
                OutInfo = (dt.Rows[0]["outinfo"] == null ? string.Empty : dt.Rows[0]["outinfo"].ToString()); //出口控制信息

                if (string.IsNullOrEmpty(OutInfo))
                {
                    //只有一个出口
                    OutInfo = EnterInfo;
                }

                Video1 = (dt.Rows[0]["video1"] == null ? string.Empty : dt.Rows[0]["video1"].ToString()); //视频1
                Video2 = (dt.Rows[0]["video2"] == null ? string.Empty : dt.Rows[0]["video2"].ToString());//视频2
                Video3 = (dt.Rows[0]["video3"] == null ? string.Empty : dt.Rows[0]["video3"].ToString());//视频3
                Video4 = (dt.Rows[0]["video4"] == null ? string.Empty : dt.Rows[0]["video4"].ToString());//视频4
            }
            //视频1
            if (string.IsNullOrEmpty(Video1))
            {
                lbVideo1.Text = string.Empty;
                rpVideo1.BackgroundImage = Devgis.Client.Properties.Resources.nosignal;
            }
            else
            {
                lbVideo1.Text = Video1;
                rpVideo1.BackgroundImage = Devgis.Client.Properties.Resources.signal;
                //初始化视频1
            }

            //视频2
            if (string.IsNullOrEmpty(Video2))
            {
                lbVideo2.Text = string.Empty;
                rpVideo2.BackgroundImage = Devgis.Client.Properties.Resources.nosignal;
            }
            else
            {
                lbVideo2.Text = Video2;
                rpVideo2.BackgroundImage = Devgis.Client.Properties.Resources.signal;
                //初始化视频2
            }
            //视频3
            if (string.IsNullOrEmpty(Video3))
            {
                lbVideo3.Text = string.Empty;
                rpVideo3.BackgroundImage = Devgis.Client.Properties.Resources.nosignal;
            }
            else
            {
                lbVideo3.Text = Video3;
                rpVideo3.BackgroundImage = Devgis.Client.Properties.Resources.signal;
                //初始化视频3
            }

            //视频4
            if (string.IsNullOrEmpty(Video4))
            {
                lbVideo4.Text = string.Empty;
                rpVideo4.BackgroundImage = Devgis.Client.Properties.Resources.nosignal;
            }
            else
            {
                lbVideo4.Text = Video4;
                rpVideo4.BackgroundImage = Devgis.Client.Properties.Resources.signal;
                //初始化视频4
            }
        }

        /// <summary>
        /// 获取设备信息
        /// </summary>
        private void GetEquipInfo()
        {
            string sql = string.Format("select name,connectinfo from t_equipment where sentryboxid='{0}'", PublicDim.SentryBoxID);
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            rgvEquipment.DataSource = dt;
        }
        #endregion

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("确定要交班吗？") == DialogResult.OK)
            {
                if (PublicDim.OffWork())
                {
                    MessageHelper.ShowInfoMessage("交班成功！");
                    Application.Restart();
                }
                else
                {
                    MessageHelper.ShowErrorMessage("交班失败，请稍后再试！");
                }
            }
        }

        private void rbtOpenEnter_Click(object sender, EventArgs e)
        {
            //MusicHelper.Play(System.IO.Path.Combine(Application.StartupPath, "default.mp3")); 播放音乐
            string carNo=rtbEnterCarNo.Text;

            //查询是否在黑名单
            string sql = string.Format("select * from t_carblacklist where carno='{0}'", carNo);
            DataTable dttemp = MySQLHelper.ExecuteQuery(sql).Tables[0];
            if (dttemp != null && dttemp.Rows.Count > 0)
            {
                //在黑名单
                if (MessageHelper.ShowQuestion("当前车牌号在黑名单，是否允许进入？") != DialogResult.OK)
                {
                    MusicHelper.Play(PublicDim.configInfo.Music3Path);
                    return;
                }
            }

            sql = string.Format("select * from t_parkingcar where carno='{0}'", carNo);
            dttemp = MySQLHelper.ExecuteQuery(sql).Tables[0];
            if (dttemp != null && dttemp.Rows.Count > 0)
            {
                //当前车辆已经在场
                MessageHelper.ShowErrorMessage("当前车辆已经在场，请检查！");
                MusicHelper.Play(PublicDim.configInfo.Music4Path);
                return;
            }

            if (PublicDim.CheckCarNO(carNo))
            {
                if (PublicDim.OpenEnter(carNo, EnterInfo))
                {
                    MusicHelper.Play(PublicDim.configInfo.Music1Path);
                    MessageHelper.ShowInfoMessage("进场成功！");
                    rtbEnterCarNo.Text = string.Empty;
                }
                else
                {
                    MusicHelper.Play(PublicDim.configInfo.Music4Path);
                    MessageHelper.ShowErrorMessage("进场失败！");
                }
            }
        }

        private void rtbOpenOutFee_Click(object sender, EventArgs e)
        {

            if (PublicDim.CheckCarNO(rtbOutCarNo.Text))
            {
                double amount = 0;
                try
                {
                    amount = Convert.ToDouble(rtbAmount.Text);
                    if (amount <= 0)
                    {
                        MessageHelper.ShowErrorMessage("金额必须大于等于0!");
                        return;
                    }
                }
                catch
                {
                    MessageHelper.ShowErrorMessage("请输入金额!");
                    return;
                }
                if(PublicDim.OpenOutFee(rtbEnterCarNo.Text, amount, OutInfo))
                {
                    try
                    {
                        MusicHelper.Play(PublicDim.configInfo.Music2Path);
                        MessageHelper.ShowErrorMessage("收费成功！");
                        rtbOutCarNo.Text = string.Empty;
                    }
                    catch
                    {
                        MessageHelper.ShowErrorMessage("收费失败！");
                    }
                }
            }
        }

        private void rbtSearchParkingCar_Click(object sender, EventArgs e)
        {
            CarList frmCarList = new CarList();
            frmCarList.ShowDialog();
        }

        private void rtbSetting_Click(object sender, EventArgs e)
        {
            Setting frmSetting = new Setting();
            frmSetting.ShowDialog();
        }

        private void rtbOutCarNo_TextChanged(object sender, EventArgs e)
        {
            //查询停车信息
            string sql = String.Format("select entertime,now() as outtime from t_parkingcar  where carno='{0}' and parkingid='{1}'"
                , rtbOutCarNo.Text, PublicDim.ParkingID);
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                //计算停车费
                DateTime dtStart = Convert.ToDateTime(dt.Rows[0]["entertime"]);
                DateTime dtEnd = Convert.ToDateTime(dt.Rows[0]["outtime"]);
                rtbAmount.Text = GetFee(dtStart, dtEnd).ToString("0.0");
            }
            else
            {
                //读取不到停车费
                rtbAmount.Text = "0";
            }
        }


        //liyafei  //注意检测到进场车辆和出场车辆如果查询到跟会员关联进行自动进场出场操作
        //liyafei need do

        /// <summary>
        /// 自动进场
        /// </summary>
        /// <param name="CarNo"></param>
        private void AutoEnter(string CarNo)
        {
            //判断是否在黑名单

            //不在黑名单 进场


            //查询是否在黑名单
            string sql = string.Format("select * from t_carblacklist where carno='{0}'", CarNo);
            DataTable dttemp = MySQLHelper.ExecuteQuery(sql).Tables[0];
            if (dttemp != null && dttemp.Rows.Count > 0)
            {
                //在黑名单
                MusicHelper.Play(PublicDim.configInfo.Music3Path);
                rtbEnterCarNo.Text = CarNo;
                return;
            }

            sql = string.Format("select * from t_parkingcar where carno='{0}'", CarNo);
            dttemp = MySQLHelper.ExecuteQuery(sql).Tables[0];
            if (dttemp != null && dttemp.Rows.Count > 0)
            {
                //当前车辆已经在场
                rtbEnterCarNo.Text = CarNo;
                MusicHelper.Play(PublicDim.configInfo.Music4Path);
                return;
            }

            if (PublicDim.CheckCarNO(CarNo))
            {
                if (PublicDim.OpenEnter(CarNo, EnterInfo))
                {
                    //进场成功
                    //MessageHelper.ShowInfoMessage("进场成功！");
                    rtbEnterCarNo.Text = string.Empty;
                    MusicHelper.Play(PublicDim.configInfo.Music1Path);
                }
                else
                {
                    //进场失败
                    rtbEnterCarNo.Text = CarNo;
                    MusicHelper.Play(PublicDim.configInfo.Music4Path);
                    //MessageHelper.ShowErrorMessage("进场失败！");
                }
            }

        }

        private void AutoOut(string CarNo)
        {
            //是否会员
            //查询车辆对应会员信息
            string sql=string.Format("select memberid from v_car where carno='{0}'",CarNo);
            DataTable dt = null;
            try
            {
                dt=MySQLHelper.ExecuteQuery(sql).Tables[0];
            }
            catch
            {
                //获取会员信息失败
                rtbOutCarNo.Text = CarNo;
                MusicHelper.Play(PublicDim.configInfo.Music4Path);
                return;
            }

            if (dt != null && dt.Rows.Count>0)
            {
                //获取会员余额
                string memberid = dt.Rows[0]["memberid"].ToString();

                //查询会员余额
                double memberacount = 0;

                sql = string.Format("select balance from t_member where id='{0}'", memberid);
                try
                {
                    memberacount = Convert.ToDouble(MySQLHelper.ExecuteQuery(sql).Tables[0].Rows[0][0]); //查询余额

                }
                catch
                {
                    //获取会员余额信息失败
                    rtbOutCarNo.Text = CarNo;
                    MusicHelper.Play(PublicDim.configInfo.Music4Path);
                }

                //查询停车时间
                //查询停车信息
                sql = String.Format("select entertime,now() as outtime,id from t_parkingcar  where carno='{0}' and parkingid='{1}'"
                    , CarNo, PublicDim.ParkingID);
                dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    //计算停车费
                    DateTime dtStart = Convert.ToDateTime(dt.Rows[0]["entertime"]);
                    DateTime dtEnd = Convert.ToDateTime(dt.Rows[0]["outtime"]);
                    string ParkCarID = dt.Rows[0]["id"].ToString(); //停车记录ID 用于删除
                    double amount = GetFee(dtStart, dtEnd);
                    if (amount > memberacount)
                    {
                        //账户余额不足
                        rtbOutCarNo.Text = CarNo;
                        MusicHelper.Play(PublicDim.configInfo.Music4Path);
                    }
                    else
                    {
                        //自动结账 事物方式

                        //删除停车记录
                        string sql1 = "delete from t_parkingcar where id=@id";
                        MySqlParameter[] arrParameter = new MySqlParameter[1];
                        arrParameter[0] = new MySqlParameter("@id", ParkCarID);


                        string sql2 = "insert into t_parkingcarlog(id,parkingid,carno,sentryboxid,entertime,outtime,memberid,couponsid,amount,operatorid,operatortime,entertime)"
                            + "values(@id,@parkingid,@carno,@sentryboxid,@entertime,now(),@memberid,@couponsid,@amount,@operatorid,now(),@entertime)";
                        MySqlParameter[] arrParameter2 = new MySqlParameter[9];
                        arrParameter2[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
                        arrParameter2[1] = new MySqlParameter("@parkingid", PublicDim.ParkingID);
                        arrParameter2[2] = new MySqlParameter("@carno", CarNo);
                        arrParameter2[3] = new MySqlParameter("@sentryboxid", PublicDim.SentryBoxID);
                        arrParameter2[4] = new MySqlParameter("@entertime", dtEnd);
                        arrParameter2[5] = new MySqlParameter("@memberid", memberid);
                        arrParameter2[6] = new MySqlParameter("@couponsid", string.Empty);
                        arrParameter2[7] = new MySqlParameter("@amount", amount);
                        arrParameter2[8] = new MySqlParameter("@operatorid", PublicDim.OperatorID);
                        arrParameter2[9] = new MySqlParameter("@entertime", dtEnd);

                        //扣会员账号
                        string sql3 = "update t_member set balance=balance-@amount where id=@memeberid";
                        MySqlParameter[] arrParameter3 = new MySqlParameter[2];
                        arrParameter3[0] = new MySqlParameter("@amount", amount);
                        arrParameter3[1] = new MySqlParameter("@memeberid", memberid);

                        List<string> listSQLs = new List<string>();
                        listSQLs.Add(sql1);
                        listSQLs.Add(sql2);
                        listSQLs.Add(sql3);

                        List<MySqlParameter[]> listMySqlParameters = new List<MySqlParameter[]>();
                        listMySqlParameters.Add(arrParameter);
                        listMySqlParameters.Add(arrParameter2);
                        listMySqlParameters.Add(arrParameter3);
                        try
                        {
                            //事务提交
                            MySQLHelper.ExecuteTrans(listSQLs, listMySqlParameters);
                            PublicDim.OpenDoor(OutInfo);//开闸
                        }
                        catch
                        {
                            //失败 去走手动流程吧
                            rtbOutCarNo.Text = CarNo;
                            MusicHelper.Play(PublicDim.configInfo.Music4Path);
                        }


                    }
                }
                else
                {
                    //读取不到停车费
                    rtbOutCarNo.Text = CarNo;
                    MusicHelper.Play(PublicDim.configInfo.Music4Path);
                }
            }
            else
            {
                MusicHelper.Play(PublicDim.configInfo.Music4Path);//播放未识别音乐
                rtbOutCarNo.Text = CarNo;
            }
        }
    }
}
