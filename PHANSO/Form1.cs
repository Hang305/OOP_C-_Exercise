using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsApp1;

namespace phanso
{
    public partial class Form1 : Form
    {
        int ts1, ms1, ts2, ms2, kqTu, kqMau, uoc;


        public Form1()
        {
            InitializeComponent();

        }

        //kiểm tra dữ liệu vào
        private bool isInputValid()
        {
            if ( ms1 == 0 )
            {
                DialogResult result = MessageBox.Show("Mẫu không được bằng 0 ở mẫu số phân số 1 !", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else if ( ms2 == 0 )
            {
                DialogResult result = MessageBox.Show("Mẫu không được bằng 0 ở mẫu số phân số 2 !", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        //thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //cộng
        private void btnCong_Click(object sender, EventArgs e)
        {
            ts1 = int.Parse(txTuSo1.Text);
            ms1 = int.Parse(txMauSo1.Text);
            ts2 = int.Parse(txTuSo2.Text);
            ms2 = int.Parse(txMauSo2.Text);

            if ( isInputValid() == false )
            {
                kqMau = 0;
                kqTu = 0;
            }
            else
            {
                kqTu = ts1 * ms2 + ts2 * ms1;
                kqMau = ms1 * ms2;
                int uoc = UCLN(kqTu, kqMau);
                kqTu = kqTu / uoc;
                kqMau = kqMau / uoc;
            }

            txKQTu.Text = kqTu.ToString();
            txKQMau.Text = kqMau.ToString();
        }


        //trừ
        private void btnTru_Click(object sender, EventArgs e)
        {
            ts1 = int.Parse(txTuSo1.Text);
            ms1 = int.Parse(txMauSo1.Text);
            ts2 = int.Parse(txTuSo2.Text);
            ms2 = int.Parse(txMauSo2.Text);

            if ( isInputValid() == false )
            {
                kqMau = 0;
                kqTu = 0;
            }
            else
            {
                kqTu = ts1 * ms2 - ts2 * ms1;
                kqMau = ms1 * ms2;
                uoc = UCLN(kqTu, kqMau);
                kqTu = kqTu / uoc;
                kqMau = kqMau / uoc;
            }

            txKQTu.Text = kqTu.ToString();
            txKQMau.Text = kqMau.ToString();
        }
        //nhân
        private void btnNhan_Click(object sender, EventArgs e)
        {
            ts1 = int.Parse(txTuSo1.Text);
            ms1 = int.Parse(txMauSo1.Text);
            ts2 = int.Parse(txTuSo2.Text);
            ms2 = int.Parse(txMauSo2.Text);

            if ( isInputValid() == false || ts1 == 0 || ts2 == 0 )
            {
                kqMau = 0;
                kqTu = 0;
            }


            else
            {
                kqTu = ts1 * ts2;
                kqMau = ms1 * ms2;
                uoc = UCLN(kqTu, kqMau);
                kqTu = kqTu / uoc;
                kqMau = kqMau / uoc;
            }

            txKQTu.Text = kqTu.ToString();
            txKQMau.Text = kqMau.ToString();
        }
        //chia
        private void btnChia_Click(object sender, EventArgs e)
        {
            ts1 = int.Parse(txTuSo1.Text);
            ms1 = int.Parse(txMauSo1.Text);
            ts2 = int.Parse(txTuSo2.Text);
            ms2 = int.Parse(txMauSo2.Text);

            if ( isInputValid() == false || ts1 == 0 )
            {
                kqMau = 0;
                kqTu = 0;
            }

            else
            {
                kqTu = ts1 * ms2;
                kqMau = ms1 * ts2;
                int uoc = UCLN(kqTu, kqMau);
                kqTu = kqTu / uoc;
                kqMau = kqMau / uoc;
            }

            txKQTu.Text = kqTu.ToString();
            txKQMau.Text = kqMau.ToString();
        }
        //làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            foreach ( Control tbx in this.Controls )
            {
                if ( tbx is TextBox )
                    ( ( TextBox )tbx ).Text = " ";
            }
        }

        //rút gọn

        public int UCLN(int ts, int ms)
        {
            ts = Math.Abs(ts);
            ms = Math.Abs(ms);

            int uoc = 1;
            int j = ( ts < ms ) ? ts : ms;
            for ( int i = 2 ; i <= j ; i++ )
            {
                if ( ts % i == 0 && ms % i == 0 )
                {
                    uoc = i;
                }
            }

            return uoc;

        }
    }
}
