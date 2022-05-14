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
using Devgis.Manager.Sys;
using Devgis.Manager.APP;
using Devgis.Manager.Parking;
using Devgis.Manager.Car;
using Devgis.Manager.Parking.Basic;
using Devgis.Manager.Financial;
using Devgis.Manager.Coupons;
using Devgis.Manager.ReportSearchs;

namespace Devgis.Manager
{
    public partial class MainForm : BaseWindow
    {
        #region 构造方法
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            //DataTable dt = MySQLHelper.ExecuteQuery("select * from t_operator").Tables[0];
            //MessageHelper.ShowInfoMessage("行数：" + dt.Rows.Count);
            PublicClass.WriteLog(PublicDim.OperatorID, "登陆系统");
        }
        /// <summary>
        /// 账号管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiOperatorManager_Click(object sender, EventArgs e)
        {
            OperatorList frmOperatorList = new OperatorList();
            frmOperatorList.ShowDialog();
        }
        /// <summary>
        /// 日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiLog_Click(object sender, EventArgs e)
        {
            LogList frmLogList = new LogList();
            frmLogList.ShowDialog();
        }
        /// <summary>
        /// 会员管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiMemberManager_Click(object sender, EventArgs e)
        {
            MemberList frmMemberList = new MemberList();
            frmMemberList.ShowDialog();
        }
        /// <summary>
        /// 交接班记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiDutyLog_Click(object sender, EventArgs e)
        {
            DutyLogList frmDutyLogList = new DutyLogList();
            frmDutyLogList.ShowDialog();
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword frmChangePassword = new ChangePassword();
            frmChangePassword.ShowDialog();
        }
        
        /// <summary>
        /// 停车场管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiParkingManager_Click(object sender, EventArgs e)
        {
            ParkingList frmParkingList = new ParkingList();
            frmParkingList.ShowDialog();
        }
        
        /// <summary>
        /// 收费规则
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiChargeRule_Click(object sender, EventArgs e)
        {
            ChargeRuleList frmChargeRuleList = new ChargeRuleList();
            frmChargeRuleList.ShowDialog();
        }
        
        /// <summary>
        /// 充值管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiRecharge_Click(object sender, EventArgs e)
        {
            RechargeList frmRechargeList = new RechargeList();
            frmRechargeList.ShowDialog();
        }
        
        #region 车辆管理
        /// <summary>
        /// 车辆管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiCarManager_Click(object sender, EventArgs e)
        {
            CarList frmCarList = new CarList();
            frmCarList.ShowDialog();
        }
        /// <summary>
        /// 车辆类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiCarType_Click(object sender, EventArgs e)
        {
            CarTypeList frmCarTypeList = new CarTypeList();
            frmCarTypeList.ShowDialog();
        }
        /// <summary>
        /// 缴费历史
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiPayHistory_Click(object sender, EventArgs e)
        {
            PayHistoryList frmPayHistoryList = new PayHistoryList();
            frmPayHistoryList.ShowDialog();
        }
        /// <summary>
        /// 黑名单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiBlackList_Click(object sender, EventArgs e)
        {
            BlackList frmBlackList = new BlackList();
            frmBlackList.ShowDialog();
        }
        #endregion

        #region 停车场管理 基础信息
        /// <summary>
        /// 月卡管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiMonthCard_Click(object sender, EventArgs e)
        {
            MonthCardList frmMonthCardMemberList = new MonthCardList();
            frmMonthCardMemberList.ShowDialog();
        }

        /// <summary>
        /// 岗亭管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiSentryBox_Click(object sender, EventArgs e)
        {
            SentryBoxList frmSentryBoxList = new SentryBoxList();
            frmSentryBoxList.ShowDialog();
        }

        /// <summary>
        /// 设备管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiEquipment_Click(object sender, EventArgs e)
        {
            EquipmentList frmEquipmentList = new EquipmentList();
            frmEquipmentList.ShowDialog();
        }
        #endregion

        #region 财务结算
        /// <summary>
        /// 财务结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiAddSettle_Click(object sender, EventArgs e)
        {
            AddSettle frmAddSettle = new AddSettle();
            frmAddSettle.ShowDialog();
        }

        /// <summary>
        /// 账户余额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiBanlaces_Click(object sender, EventArgs e)
        {
            BalancesList frmBalancesList = new BalancesList();
            frmBalancesList.ShowDialog();
        }

        /// <summary>
        /// 结算历史
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiSettleHistory_Click(object sender, EventArgs e)
        {
            SettleList frmSettleList = new SettleList();
            frmSettleList.ShowDialog();
        }
        /// <summary>
        /// 转账历史
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiTransfer_Click(object sender, EventArgs e)
        {
            TransferList frmTransferList = new TransferList();
            frmTransferList.ShowDialog();
        }
        #endregion

        #region 优惠卷
        /// <summary>
        /// 批量生成优惠券
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiAddCoupons_Click(object sender, EventArgs e)
        {
            AddCoupons frmAddCoupons = new AddCoupons();
            frmAddCoupons.ShowDialog();
        }
        /// <summary>
        /// 优惠券列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiCouponsList_Click(object sender, EventArgs e)
        {
            CouponsList frmCouponsList = new CouponsList();
            frmCouponsList.ShowDialog();
        }
        #endregion

        #endregion

        #region 统计报表
        /// <summary>
        /// 停车场统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiPakingStat_Click(object sender, EventArgs e)
        {
            ReportItem item = new ReportItem
            {
                QueryString = "select zone 地区,count(zone) as 数量 from t_parking group by zone",
                ReportName = "停车场统计",
                EnableTime = false
            };
            ReportView frmReport = new ReportView();
            frmReport.Item = item;
            frmReport.ShowDialog();
        }
        /// <summary>
        /// 收费报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiFeeReport_Click(object sender, EventArgs e)
        {
            string sql = "select parkingname as 停车场,sum(amount) as 收费金额  from v_parkingcarlog where operatortime between '{0}' and '{1}' group by parkingname";
            ReportItem item = new ReportItem
            {
                QueryString = sql,
                ReportName = "收费统计"
            };
            ReportView frmReport = new ReportView();
            frmReport.Item = item;
            frmReport.ShowDialog();
        }
        /// <summary>
        /// 车流量报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiCarNumReport_Click(object sender, EventArgs e)
        {
            string sql = "select parkingname as 停车场,count(parkingname) as 车流量  from v_parkingcarlog where operatortime between '{0}' and '{1}' group by parkingname";
            ReportItem item = new ReportItem
            {
                QueryString = sql,
                ReportName = "车流量统计"
            };
            ReportView frmReport = new ReportView();
            frmReport.Item = item;
            frmReport.ShowDialog();
        }
        /// <summary>
        /// 收费员收费报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiOperatorFeeReport_Click(object sender, EventArgs e)
        {
            string sql = "select operatorname as 收费员,sum(amount) as 收费金额  from v_parkingcarlog where operatortime between '{0}' and '{1}' group by operatorname";
            ReportItem item = new ReportItem
            {
                QueryString = sql,
                ReportName = "收费员收费统计"
            };
            ReportView frmReport = new ReportView();
            frmReport.Item = item;
            frmReport.ShowDialog();
        }
        /// <summary>
        /// 会员报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiMemberReport_Click(object sender, EventArgs e)
        {
            string sql="select '会员总数' as 项目,count(*) as 数量 from t_operator union select '车辆总数' as 项目,count(*) as 数量 from t_car union select '充值总金额' as 项目, sum(amount) as 数量 from t_rechargehistory";
            ReportItem item = new ReportItem
            {
                QueryString = sql,
                ReportName = "会员统计",
                EnableTime = false
            };
            ReportView frmReport = new ReportView();
            frmReport.Item = item;
            frmReport.ShowDialog();
        }
        #endregion

        /// <summary>
        /// 车辆明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radCarDetail_Click(object sender, EventArgs e)
        {
            CarDetailSearch frmCarDetailSearch = new CarDetailSearch();
            frmCarDetailSearch.ShowDialog();
        }
        /// <summary>
        /// 手动开闸记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiManulOpen_Click(object sender, EventArgs e)
        {
            ManulOpenSearch frmManulOpenSearch = new ManulOpenSearch();
            frmManulOpenSearch.ShowDialog();
        }
        /// <summary>
        /// 在场明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiPartingCar_Click(object sender, EventArgs e)
        {
            ParkingCarSearch frmParkingCarSearch = new ParkingCarSearch();
            frmParkingCarSearch.ShowDialog();
        }
        /// <summary>
        /// 异常车辆查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmiExceptionCar_Click(object sender, EventArgs e)
        {
            ExceptionCarSearch frmExceptionCarSearch = new ExceptionCarSearch();
            frmExceptionCarSearch.ShowDialog();
        }

        private void cmdReLogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
