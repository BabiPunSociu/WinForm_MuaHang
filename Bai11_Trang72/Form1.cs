using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11_Trang72
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                lstMatHang.Items.Add("sản phẩm " + (i + 1));
        }

        private void lstMatHang_DoubleClick(object sender, EventArgs e)
        {
            string str = lstMatHang.SelectedItem.ToString();
            for (int i = 0; i < lstGioHang.Items.Count; i++)
            {
                if (lstGioHang.Items[i].ToString() == str)
                {
                    MessageBox.Show("Mặt hàng này đã có sẵn trong giỏ hàng");
                    return;
                }
            }

            lstGioHang.Items.Add(str);
            MessageBox.Show("Bạn đã thêm " + str + " vào giỏ hàng");
        }

        private void lstGioHang_DoubleClick(object sender, EventArgs e)
        {
            int index = lstGioHang.SelectedIndex;
            if(MessageBox.Show("Bạn muốn xóa '" + lstGioHang.Items[index] + "' khỏi giỏ hàng không?", "Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {   // yes -> xóa
                lstGioHang.Items.RemoveAt(index);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát không?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string str = "Họ tên khách: ";
            // họ tên
            if(txtHoTen.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên");
                txtHoTen.Focus();
                return;
            }    
            str += txtHoTen.Text.Trim() + "\n" + "Số điện thoại:";
            // Số điện thoại
            if(txtSĐT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải bao gồm 10 số");
                txtSĐT.Focus();
                return;
            }
            str += txtSĐT.Text + "\n";
            // Danh sách hàng đặt mua
            if(lstGioHang.Items.Count <= 0)
            {
                MessageBox.Show("Bạn chưa có gì trong giỏ hàng");
                return;
            }
            str += "Danh sách hàng đặt mua";
            foreach(string item in lstGioHang.Items)
            {
                str += "\n- " + item;
            }
            // phương thức thanh toán
            if (rdoTienMat.Checked == true)
                str += "\nPhương thức thanh toán: Tiền mặt";
            else if(rdoZalopay.Checked == true)
                str += "\nPhương thức thanh toán: Zalopay";
            else if(rdoTheNganHang.Checked)
                str += "\nPhương thức thanh toán: Thẻ ngân hàng";
            else
            {
                MessageBox.Show("Bạn chưa chọn hình thức thanh toán");
                return;
            }

            // Hình thức liên lạc
            str += "\nHình thức liên lạc: ";
            if(!ckbDienThoai.Checked && !ckbFax.Checked && !ckbEmail.Checked)
            {
                MessageBox.Show("Bạn chưa chọn hình thức liên lạc");
                return;
            }
            if (ckbDienThoai.Checked)
                str += "Điện Thoại, ";
            if (ckbFax.Checked)
                str += "Fax, ";
            if (ckbEmail.Checked)
                str += "Email, ";

            str = str.Substring(0, str.Length - 2);

            MessageBox.Show(str);
        }
    }
}
