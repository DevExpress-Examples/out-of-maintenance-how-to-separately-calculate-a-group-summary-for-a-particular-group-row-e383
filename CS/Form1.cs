using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace summary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = CarList.GetList();
        }

        int counter;
        int ivalue;
        double dvalue;

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (!e.IsGroupSummary) return;
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                ivalue = 0;
                dvalue = 0;
                counter = 0;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                if (((GridGroupSummaryItem)e.Item).FieldName == "HP")
                    if (e.GroupRowHandle % 2 == 0)
                        ivalue += (Int16)e.FieldValue;
                    else
                        ivalue += 1;
                if (((GridGroupSummaryItem)e.Item).FieldName == "Liter")
                    if (e.GroupRowHandle % 2 == 0)
                        dvalue = Math.Max(dvalue, (double)e.FieldValue);
                    else
                    {
                        dvalue += (double)e.FieldValue;
                        counter++;
                    }
            }
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                if (((GridGroupSummaryItem)e.Item).FieldName == "HP")
                    if (e.GroupRowHandle % 2 == 0)
                        e.TotalValue = ivalue;
                    else
                        e.TotalValue = ivalue;
                if (((GridGroupSummaryItem)e.Item).FieldName == "Liter")
                    if (e.GroupRowHandle % 2 == 0)
                        e.TotalValue = dvalue;
                    else
                        e.TotalValue = dvalue / counter;
            }
        }

        private void gridView1_CustomDrawRowFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column.FieldName == "HP")
                if (e.RowHandle % 2 == 0)
                    e.Info.DisplayText = string.Format("Total: {0}", view.GetGroupSummaryValue(e.RowHandle, (GridGroupSummaryItem)view.GroupSummary[0]));
                else
                    e.Info.DisplayText = string.Format("Count: {0}", view.GetGroupSummaryValue(e.RowHandle, (GridGroupSummaryItem)view.GroupSummary[0]));
            if (e.Column.FieldName == "Liter")
                if (e.RowHandle % 2 == 0)
                    e.Info.DisplayText = string.Format("Max: {0}", view.GetGroupSummaryValue(e.RowHandle, (GridGroupSummaryItem)view.GroupSummary[1]));
                else
                    e.Info.DisplayText = string.Format("Avr: {0}", view.GetGroupSummaryValue(e.RowHandle, (GridGroupSummaryItem)view.GroupSummary[1]));
        }
    }
}