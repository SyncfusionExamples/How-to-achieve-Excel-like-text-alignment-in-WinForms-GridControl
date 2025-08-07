using System.Windows.Forms;

namespace ExcelLikeTextAlignment_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridControl1.RowCount = 10;
            gridControl1.ColCount = 6;
            gridControl1.ExcelLikeAlignment = true;
            //Fill first half of columns with numeric values
            for (int i = 1; i <= gridControl1.RowCount; i++)
            {
                for (int j = 0; j <= gridControl1.ColCount/2; j++)
                {
                    gridControl1[i, j].CellValue = i+j;
                }
            }
            //Fill second half of columns with "Data"
            for (int i = 1; i <= gridControl1.RowCount; i++)
            {
                for (int j = gridControl1.ColCount / 2+1; j <= gridControl1.ColCount; j++)
                {
                    gridControl1[i, j].CellValue = "Data";
                }
            }
        }
    }
}