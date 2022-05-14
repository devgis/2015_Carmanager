using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using MySql.Data.MySqlClient;
using Devgis.Common;
using System.Data;

namespace Devgis.Client
{
    public class PublicDim
    {
        /// <summary>
        /// 停车场ID
        /// </summary>
        public static string ParkingID = "2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf";

        /// <summary>
        /// 停车场名称
        /// </summary>
        public static string ParkingName = "测试停车场";

        /// <summary>
        /// 岗亭ID
        /// </summary>
        public static string SentryBoxID = "0c885fb4-de36-4a30-a96a-ba1ef98a493a";

        /// <summary>
        /// 岗亭名称
        /// </summary>
        public static string SentryBoxName = "测试名称";

        /// <summary>
        /// 当前登陆用户权限
        /// </summary>
        public static int RoleID = 4; // 1 超级管理员、2 平台普通管理员，3 停车场管理员、4 停车场收费员

        /// <summary>
        /// 当前登陆用户
        /// </summary>
        public static string OperatorID = "fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34";

        /// <summary>
        /// 真是名称
        /// </summary>
        public static string RealName = "001";

        /// <summary>
        /// 文件路径
        /// </summary>
        public static string ConfigFileName = System.IO.Path.Combine(Application.StartupPath, "Setting.Config");

        /// <summary>
        /// 配置信息
        /// </summary>
        public static ConfigClass configInfo = null;

        /// <summary>
        /// 角色字典
        /// </summary>
        public static Dictionary<int, string> DicRole
        {
            get;
            set;

        }

        #region 私有方法
        /// <summary>
        /// 检查车牌号 合法返回True 否则弹出提示返回false
        /// </summary>
        /// <param name="CarNo"></param>
        /// <returns></returns>
        public static bool CheckCarNO(string CarNo)
        {
            if (CarNo == null || string.IsNullOrEmpty(CarNo) || string.IsNullOrEmpty(CarNo.Trim()))
            {
                MessageHelper.ShowErrorMessage("车牌不能为空！");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 上班
        /// </summary>
        /// <returns></returns>
        public static bool StartWork()
        {
            MySqlParameter[] arrParameter = new MySqlParameter[3];
            string sql = "insert into t_dutylog (id,operatorid,dutytype,dutytime)values(@id,@operatorid,@dutytype,now())";
            arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
            arrParameter[1] = new MySqlParameter("@operatorid",PublicDim.OperatorID);
            arrParameter[2] = new MySqlParameter("@dutytype", "上班");
            if (MySQLHelper.ExecuteNonQuery(sql, arrParameter) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 下班
        /// </summary>
        /// <returns></returns>
        public static bool OffWork()
        {
            MySqlParameter[] arrParameter = new MySqlParameter[3];
            string sql = "insert into t_dutylog (id,operatorid,dutytype,dutytime)values(@id,@operatorid,@dutytype,now())";
            arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
            arrParameter[1] = new MySqlParameter("@operatorid", PublicDim.OperatorID);
            arrParameter[2] = new MySqlParameter("@dutytype", "下班");
            if (MySQLHelper.ExecuteNonQuery(sql, arrParameter) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 手动开门进场
        /// </summary>
        /// <param name="CarNO">车牌号</param>
        /// <param name="DoorInfo">开闸信息用于控制硬件开闸</param>
        /// <returns></returns>
        public static bool OpenEnter(string CarNO, string DoorInfo)
        {
            MySqlParameter[] arrParameter = new MySqlParameter[6];
            string sql = "insert into t_parkingcar (id,parkingid,sentryboxid,memberid,carno,entertime,operatorid)values(@id,@parkingid,@sentryboxid,@memberid,@carno,now(),@operatorid)";
            arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
            arrParameter[1] = new MySqlParameter("@parkingid", PublicDim.ParkingID);
            arrParameter[2] = new MySqlParameter("@sentryboxid",PublicDim.SentryBoxID);
            arrParameter[3] = new MySqlParameter("@memberid",string.Empty);
            arrParameter[4] = new MySqlParameter("@carno", CarNO);
            arrParameter[5] = new MySqlParameter("@operatorid", PublicDim.OperatorID);
            if (MySQLHelper.ExecuteNonQuery(sql, arrParameter) > 0)
            {
                return OpenDoor(DoorInfo);//开闸
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 开门收费出场
        /// </summary>
        /// <param name="CarNO">车牌号</param>
        /// <param name="Amount">收费金额</param>
        /// <param name="DoorInfo">开闸信息用于控制硬件开闸</param>
        /// <returns></returns>
        public static bool OpenOutFee(string CarNO, double Amount, string DoorInfo)
        {
            //读取记录停车记录
            string sql = string.Format("select * from t_parkingcar where carno='{0}' and parkingid='{1}'", CarNO,PublicDim.ParkingID);
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                //生成插入记录记录
                DateTime Entertime = Convert.ToDateTime(dt.Rows[0]["entertime"]);
                string ID = (dt.Rows[0]["id"] == null ? string.Empty : dt.Rows[0]["id"].ToString()); 
                string MemberID = (dt.Rows[0]["memberid"] == null ? string.Empty : dt.Rows[0]["memberid"].ToString());
                string EnterSentryBoxID = (dt.Rows[0]["memberid"] == null ? string.Empty : dt.Rows[0]["memberid"].ToString()); 

                //删除停车记录
                string sql1 = "delete from t_parkingcar where id=@id";
                MySqlParameter[] arrParameter = new MySqlParameter[1];
                arrParameter[0] = new MySqlParameter("@id",ID);


                string sql2 = "insert into t_parkingcarlog(id,parkingid,carno,sentryboxid,entertime,outtime,memberid,couponsid,amount,operatorid,operatortime)"
                    +"values(@id,@parkingid,@carno,@sentryboxid,@entertime,now(),@memberid,@couponsid,@amount,@operatorid,now())";
                MySqlParameter[] arrParameter2 = new MySqlParameter[9];
                arrParameter2[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
                arrParameter2[1] = new MySqlParameter("@parkingid",PublicDim.ParkingID);
                arrParameter2[2] = new MySqlParameter("@carno",CarNO);
                arrParameter2[3] = new MySqlParameter("@sentryboxid",PublicDim.SentryBoxID);
                arrParameter2[4] = new MySqlParameter("@entertime",Entertime);
                arrParameter2[5] = new MySqlParameter("@memberid",string.Empty);
                arrParameter2[6] = new MySqlParameter("@couponsid",string.Empty);
                arrParameter2[7] = new MySqlParameter("@amount",Amount);
                arrParameter2[8] = new MySqlParameter("@operatorid",PublicDim.OperatorID);

                List<string> listSQLs = new List<string>();
                listSQLs.Add(sql1);
                listSQLs.Add(sql2);

                List<MySqlParameter[]> listMySqlParameters = new List<MySqlParameter[]>();
                listMySqlParameters.Add(arrParameter);
                listMySqlParameters.Add(arrParameter2);
                try
                {
                    //事务提交
                    MySQLHelper.ExecuteTrans(listSQLs, listMySqlParameters);

                    OpenDoor(DoorInfo);//开闸
                    return true;
                }

                catch
                {
                    return false;
                }
            }
            else
            {
                //异常结账
                if (MessageHelper.ShowQuestion("没有检测到进场记录，请手动开闸！") == DialogResult.OK)
                {
                    string sql2 = "insert into t_parkingcarlog(id,parkingid,carno,sentryboxid,entertime,outtime,memberid,couponsid,amount,operatorid,operatortime)"
                    + "values(@id,@parkingid,@carno,@sentryboxid,now(),now(),@memberid,@couponsid,@amount,@operatorid,now())";
                    MySqlParameter[] arrParameter2 = new MySqlParameter[8];
                    arrParameter2[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
                    arrParameter2[1] = new MySqlParameter("@parkingid", PublicDim.ParkingID);
                    arrParameter2[2] = new MySqlParameter("@carno", CarNO);
                    arrParameter2[3] = new MySqlParameter("@sentryboxid", PublicDim.SentryBoxID);
                    arrParameter2[4] = new MySqlParameter("@memberid", string.Empty);
                    arrParameter2[5] = new MySqlParameter("@couponsid", string.Empty);
                    arrParameter2[6] = new MySqlParameter("@amount", Amount);
                    arrParameter2[7] = new MySqlParameter("@operatorid", PublicDim.OperatorID);


                    if (MySQLHelper.ExecuteNonQuery(sql2, arrParameter2) > 0)
                    {
                        OpenDoor(DoorInfo);//开闸
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            
        }

        /// <summary>
        /// 异常情况紧急开门
        /// </summary>
        /// <param name="CarNO">车牌号</param>
        /// <param name="Amount">收费金额</param>
        /// <param name="DoorInfo">开闸信息用于控制硬件开闸</param>
        /// <returns></returns>
        public static bool OpenOutFee2(string CarNO, double Amount, string DoorInfo)
        {
            if(OpenOutFee(CarNO,Amount,DoorInfo))
            {
                return true;
                //正常开门
            }
            else
            {
                string sql2 = "insert into t_parkingcarlog(id,parkingid,carno,sentryboxid,entertime,outtime,memberid,couponsid,amount,operatorid,operatortime)"
                    + "values(@id,@parkingid,@carno,@sentryboxid,now(),now(),@memberid,@couponsid,@amount,@operatorid,now())";
                MySqlParameter[] arrParameter2 = new MySqlParameter[8];
                arrParameter2[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
                arrParameter2[1] = new MySqlParameter("@parkingid", PublicDim.ParkingID);
                arrParameter2[2] = new MySqlParameter("@carno", CarNO);
                arrParameter2[3] = new MySqlParameter("@sentryboxid", PublicDim.SentryBoxID);
                arrParameter2[4] = new MySqlParameter("@memberid", string.Empty);
                arrParameter2[5] = new MySqlParameter("@couponsid", string.Empty);
                arrParameter2[6] = new MySqlParameter("@amount", Amount);
                arrParameter2[7] = new MySqlParameter("@operatorid", PublicDim.OperatorID);

      
                if(MySQLHelper.ExecuteNonQuery(sql2, arrParameter2)>0)
                {
                    OpenDoor(DoorInfo);//开闸
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 硬件开闸
        /// </summary>
        /// <param name="DoorInfo">开闸参数</param>
        /// <returns></returns>
        public static bool OpenDoor(string DoorInfo)
        {
            return true;
        }

        /// <summary>
        /// 获取硬件信息
        /// </summary>
        /// <param name="ConnectInfo">硬件连接信息</param>
        /// <returns></returns>
        public static string GetEquipState(string ConnectInfo)
        {
            return "正常";
        }
        #endregion

    }
}
