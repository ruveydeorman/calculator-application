namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizlenecekmi;
        int _ilksayi, _ikincisayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (_ekrantemizlenecekmi) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void sumbutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);

        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            _ikincisayi = Convert.ToInt32(ekranlabel.Text);
            int sonuc;
            switch (_islem)
            {

                case '+':
                    sonuc = _ilksayi + _ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - _ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * _ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / _ikincisayi;
                    if(sonuc == null)
                    {
                        ekranlabel.Text = "undefineded";
                    }
                    break;
                default:
                    sonuc = '0';
                    break;
            }
            ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void cýkarmabutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void multibutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void divisionbutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "";
        }
    }
}