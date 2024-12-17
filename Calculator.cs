Calculator
by Nattapat Siriwarapat , 673450035-6, Computer and Infomation Science, KKU

การรับและการแสดงผลข้อมูล
รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

ปุ่มบวก
private void button1_Click(object sender, EventArgs e) { // ข้อความตัวอักษร string inputNum1 = num1.Text; string inputNum2 = num2.Text; // convert string to number (integer) int iNum1 = Int32.Parse(inputNum1); int iNum2 = Int32.Parse(inputNum2); // int ทำให้เราสามารถทำการ + - * / ได้ int iResult = iNum1 + iNum2; // ที่ตัวแปรชื่อ result // มีคุณสมบัติชื่อ Text result.Text = iResult.ToString(); }

รับข้อมูล
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
แปลงชนิดของข้อมูล
double iNum1 = double.Parse(inputNum1);
double iNum2 = double.Parse(inputNum2);
คำนวนผลลัพท์
double iResult = iNum1 + iNum2;
แสดงผล
result.Text = iResult.ToString();
ปุ่มลบ
private void button4_Click(object sender, EventArgs e)
    {
        //ข้อความตัวอักษร
        string inputNum1 = num1.Text;
        string inputNum2 = num2.Text;

        // convert string to number (interger)
        // int => interger เลขจำนวนเต็ม
        // double / float => เลขทศนิยม
        double iNum1 = double.Parse(inputNum1);
        double iNum2 = double.Parse(inputNum2);

        // int ทำให้เราสามารถทำการ + - * / ได้
        double iResult = iNum1 - iNum2;

        // ที่ตัวแปร result
        //มีคุณสมบัตชื่อ Text
        result.Text = iResult.ToString();
    }
รับข้อมูล
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
แปลงชนิดของข้อมูล
double iNum1 = double.Parse(inputNum1);
double iNum2 = double.Parse(inputNum2);
คำนวนผลลัพท์
double iResult = iNum1 - iNum2;
แสดงผล
result.Text = iResult.ToString();
ปุ่มคูณ
private void button4_Click(object sender, EventArgs e)
    {
        //ข้อความตัวอักษร
        string inputNum1 = num1.Text;
        string inputNum2 = num2.Text;

        // convert string to number (interger)
        // int => interger เลขจำนวนเต็ม
        // double / float => เลขทศนิยม
        double iNum1 = double.Parse(inputNum1);
        double iNum2 = double.Parse(inputNum2);

        // int ทำให้เราสามารถทำการ + - * / ได้
        double iResult = iNum1 * iNum2;

        // ที่ตัวแปร result
        //มีคุณสมบัตชื่อ Text
        result.Text = iResult.ToString();
    }
รับข้อมูล
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
แปลงชนิดของข้อมูล
double iNum1 = double.Parse(inputNum1);
double iNum2 = double.Parse(inputNum2);
คำนวนผลลัพท์
double iResult = iNum1 * iNum2;
แสดงผล
result.Text = iResult.ToString();
ปุ่มหาร
private void button4_Click(object sender, EventArgs e)
    {
        //ข้อความตัวอักษร
        string inputNum1 = num1.Text;
        string inputNum2 = num2.Text;

        // convert string to number (interger)
        // int => interger เลขจำนวนเต็ม
        // double / float => เลขทศนิยม
        double iNum1 = double.Parse(inputNum1);
        double iNum2 = double.Parse(inputNum2);

        // int ทำให้เราสามารถทำการ + - * / ได้
        double iResult = iNum1 / iNum2;

        // ที่ตัวแปร result
        //มีคุณสมบัตชื่อ Text
        result.Text = iResult.ToString();
    }
รับข้อมูล
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
แปลงชนิดของข้อมูล
double iNum1 = double.Parse(inputNum1);
double iNum2 = double.Parse(inputNum2);
คำนวนผลลัพท์
double iResult = iNum1 / iNum2;
แสดงผล
result.Text = iResult.ToString();
ปุ่มลบข้อมูล
private void button3_Click(object sender, EventArgs e) { num1.Text = ""; num2.Text = ""; result.Text = ""; }