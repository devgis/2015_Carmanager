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
using Telerik.WinControls.UI;
using MySql.Data.MySqlClient;

namespace Devgis.Manager.Financial
{
    public partial class SettleList : BaseWindow
    {
        public SettleList()
        {
            InitializeComponent();
        }

        private void OperatorList_Shown(object sender, EventArgs e)
        {
            InitData();
        }

        #region 私有方法
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            rgvDataList.Rows.Clear();
            DataTable dt = MySQLHelper.ExecuteQuery("select * from v_settle").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvDataList.Rows.AddNew();
                row.Cells["colID"].Value = dr["id"];
                row.Cells["colParkingName"].Value = dr["parkingname"].ToString();
                row.Cells["colAmount"].Value = dr["amount"].ToString();
                row.Cells["colAccountOwner"].Value = dr["accountowner"].ToString();
                row.Cells["colBankName"].Value = dr["bankname"].ToString();
                row.Cells["colBankAccount"].Value = dr["bankaccount"].ToString();
                row.Cells["colRemarks"].Value = dr["remarks"].ToString();
                row.Cells["colOperatorName"].Value = dr["operatorname"].ToString();
                row.Cells["colLastEditOperator"].Value = dr["lasteditoperatorname"].ToString();
                row.Cells["colVerifyName"].Value = dr["verifyname"].ToString();
                row.Cells["colOperatorTime"].Value = dr["addtime"].ToString();
                row.Cells["colLastEditTime"].Value = dr["lastedittime"].ToString();
                row.Cells["colVerifyTime"].Value = dr["verifytime"].ToString();
                row.Cells["colState"].Value = dr["state"].ToString();
            }
            foreach (GridViewRowInfo row in rgvDataList.Rows)
            {
                if (row.Cells["colState"].Value != null && row.Cells["colState"].Value.ToString() == "1")
                {
                    row.Cells["colStateName"].Value = "已审核";
                }
                else
                {
                    row.Cells["colStateName"].Value = "未审核";
                }
            }
        }
        #endregion

        #region 界面事件方法
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            InitData(); //刷新
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string ID = string.Empty;
            foreach (GridViewRowInfo row in rgvDataList.Rows)
            {
                if (row.Cells["colSelect"].Value!=null&&(bool)row.Cells["colSelect"].Value)
                {
                    ID = row.Cells["colID"].Value.ToString();
                    Count++;
                }
            }
            if (Count <= 0)
            {
                MessageHelper.ShowErrorMessage("请选择记录进行编辑！");
            }
            else if (Count == 1)
            {
                AddSettle frmEdit = new AddSettle(ID);
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    InitData();//刷新
                }
            }
            else if (Count > 1)
            {
                MessageHelper.ShowErrorMessage("请最多选择一条记录进行编辑！");
            }
            //MessageBox.Show(Count.ToString());
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddSettle frmAddSettle = new AddSettle();
            if (frmAddSettle.ShowDialog() == DialogResult.OK)
            {
                //刷新
                InitData();
            }
        }

        private void rgvDataList_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Column.Name == "colSelect")
            {
                if (rgvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null&&(bool)rgvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    rgvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value= false;
                }
                else
                {
                    rgvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                //MessageBox.Show(e.Value.ToString());
            }
        }
        #endregion

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            AddSettle frmAdd = new AddSettle();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                //刷新
                InitData();
            }
        }

        /// <summary>
        /// 编辑s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdEdit_Click_1(object sender, EventArgs e)
        {
            int Count = 0;
            string ID = string.Empty;
            bool ContainVerifyed = false;
            foreach (GridViewRowInfo row in rgvDataList.Rows)
            {
                if (row.Cells["colSelect"].Value != null && (bool)row.Cells["colSelect"].Value)
                {
                    ID = row.Cells["colID"].Value.ToString();
                    Count++;
                }
                if (row.Cells["colState"].Value != null && Convert.ToInt32(row.Cells["colState"].Value)==1)
                {
                    ContainVerifyed = true;
                }
            }
            
            if (Count <= 0)
            {
                MessageHelper.ShowErrorMessage("请选择记录进行编辑！");
            }
            else if (Count == 1)
            {
                if (ContainVerifyed)
                {
                    MessageHelper.ShowErrorMessage("已审核项不能进行编辑！");
                    return;
                }
                else
                {
                    AddSettle frmEdit = new AddSettle(ID);
                    if (frmEdit.ShowDialog() == DialogResult.OK)
                    {
                        InitData();//刷新
                    }
                }
            }
            else if (Count > 1)
            {
                MessageHelper.ShowErrorMessage("请最多选择一条记录进行编辑！");
            }
            //MessageBox.Show(Count.ToString());
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDel_Click(object sender, EventArgs e)
        {
            string args = string.Empty;
            bool ContainVerifyed = false;
            foreach (GridViewRowInfo row in rgvDataList.Rows)
            {
                if (row.Cells["colSelect"].Value != null && (bool)row.Cells["colSelect"].Value)
                {
                    // ID = row.Cells["colID"].Value.ToString();
                    if (string.IsNullOrEmpty(args))
                    {
                        args = "'" + row.Cells["colID"].Value.ToString() + "'";
                    }
                    else
                    {
                        args += ",'" + row.Cells["colID"].Value.ToString() + "'";
                    }
                }
                if (row.Cells["colState"].Value != null && Convert.ToInt32(row.Cells["colState"].Value) == 1)
                {
                    ContainVerifyed = true;
                }
            }
            if (ContainVerifyed)
            {
                MessageHelper.ShowErrorMessage("包含已审核项，不能删除，请检查！");
                return;
            }

            if (string.IsNullOrEmpty(args))
            {
                MessageHelper.ShowErrorMessage("请选择记录进行删除！");
            }
            else
            {
                string sql = string.Format("delete from t_carblacklist where id in ({0})", args);
                if (MySQLHelper.ExecuteNonQuery(sql) > 0)
                {
                    InitData();
                    MessageHelper.ShowInfoMessage("删除成功！");
                }
                else
                {
                    MessageHelper.ShowErrorMessage("删除失败！");
                }
            }
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdVerify_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string ID = string.Empty;
            bool ContainVerifyed = false;
            foreach (GridViewRowInfo row in rgvDataList.Rows)
            {
                if (row.Cells["colSelect"].Value != null && (bool)row.Cells["colSelect"].Value)
                {
                    ID = row.Cells["colID"].Value.ToString();
                    Count++;
                }
                if (row.Cells["colState"].Value != null && Convert.ToInt32(row.Cells["colState"].Value) == 1)
                {
                    ContainVerifyed = true;
                }
            }

            if (Count <= 0)
            {
                MessageHelper.ShowErrorMessage("请选择记录进行审核！");
            }
            else if (Count == 1)
            {
                if (ContainVerifyed)
                {
                    MessageHelper.ShowErrorMessage("已审核项不能进行审核！");
                    return;
                }
                else
                {
                    //判断金额 是否适合审核
                    DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select parkingid,amount from t_settle where id='{0}'", ID)).Tables[0];
                    if (dt == null || dt.Rows.Count <= 0)
                    {
                        MessageHelper.ShowErrorMessage("读取结算数据错误！");
                        return;
                    }
                    string parkingid = dt.Rows[0]["parkingid"].ToString();
                    double amount = Convert.ToDouble(dt.Rows[0]["amount"]);

                    dt = MySQLHelper.ExecuteQuery(string.Format("select balance from t_parking where id='{0}'", parkingid)).Tables[0];
                    if (dt == null || dt.Rows.Count <= 0)
                    {
                        MessageHelper.ShowErrorMessage("读取账户信息数据错误！");
                        return;
                    }
                    try
                    {
                        double balance = Convert.ToDouble(dt.Rows[0]["balance"]);
                        if (amount > balance)
                        {
                            MessageHelper.ShowErrorMessage("余额不足无法审核！");
                            return;
                        }
                    }
                    catch
                    {
                        MessageHelper.ShowErrorMessage("读取账户信息数据错误！");
                        return;
                    }
                    
                    #region 审核
                    //计入记录表
                    string sql1 = "insert into t_transfer(id,settleid,transfertime)values(@id,@settleid,now())";
                    MySqlParameter[] arrParameter = new MySqlParameter[2];
                    arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
                    arrParameter[1] = new MySqlParameter("@settleid", ID);

                    //审核
                    string sql2 = "update t_settle set verifyid=@verifyid,verifytime=now(),state=1 where id=@id";
                    MySqlParameter[] arrParameter2 = new MySqlParameter[2];
                    arrParameter2[0] = new MySqlParameter("@id", ID);
                    arrParameter2[1] = new MySqlParameter("@verifyid", PublicDim.OperatorID);

                    //扣款
                    string sql3 = "update t_parking set balance=balance-@amount where id=@id";
                    MySqlParameter[] arrParameter3 = new MySqlParameter[2];
                    arrParameter3[0] = new MySqlParameter("@id", parkingid);
                    arrParameter3[1] = new MySqlParameter("@amount", amount);

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
                        MySQLHelper.ExecuteTrans(listSQLs, listMySqlParameters);
                        MessageHelper.ShowInfoMessage("审核成功！");
                    }
                    catch
                    {
                        MessageHelper.ShowInfoMessage("审核失败！");
                    }

                    
                    #endregion 
                }
            }
            else if (Count > 1)
            {
                MessageHelper.ShowErrorMessage("请最多选择一条记录进行审核！");
            }
        }
    }
}
