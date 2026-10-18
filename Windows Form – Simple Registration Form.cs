using System;
using System.Drawing;
using System.Windows.Forms;

namespace program9
{
    internal static class Program9
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        TextBox txtName, txtEmail;
        RadioButton rbMale, rbFemale;
        CheckBox cbReading, cbSports;
        ComboBox cmbCourse;
        Button btnRegister;

        public Form1()
        {
            Text = "Simple Registration Form";
            Size = new Size(450, 480);
            StartPosition = FormStartPosition.CenterScreen;

            Label heading = new Label();
            heading.Text = "Student Registration Form";
            heading.Location = new Point(80, 20);
            heading.Size = new Size(300, 30);
            heading.Font = new Font("Arial", 14, FontStyle.Bold);
            Controls.Add(heading);

            Label lblName = new Label();
            lblName.Text = "Name:";
            lblName.Location = new Point(40, 80);
            lblName.AutoSize = true;
            Controls.Add(lblName);

            txtName = new TextBox();
            txtName.Location = new Point(150, 75);
            txtName.Size = new Size(200, 25);
            Controls.Add(txtName);

            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new Point(40, 120);
            lblEmail.AutoSize = true;
            Controls.Add(lblEmail);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(150, 115);
            txtEmail.Size = new Size(200, 25);
            Controls.Add(txtEmail);

            Label lblGender = new Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new Point(40, 160);
            lblGender.AutoSize = true;
            Controls.Add(lblGender);

            rbMale = new RadioButton();
            rbMale.Text = "Male";
            rbMale.Location = new Point(150, 155);
            rbMale.AutoSize = true;
            Controls.Add(rbMale);

            rbFemale = new RadioButton();
            rbFemale.Text = "Female";
            rbFemale.Location = new Point(230, 155);
            rbFemale.AutoSize = true;
            Controls.Add(rbFemale);

            Label lblHobbies = new Label();
            lblHobbies.Text = "Hobbies:";
            lblHobbies.Location = new Point(40, 200);
            lblHobbies.AutoSize = true;
            Controls.Add(lblHobbies);

            cbReading = new CheckBox();
            cbReading.Text = "Reading";
            cbReading.Location = new Point(150, 195);
            cbReading.AutoSize = true;
            Controls.Add(cbReading);

            cbSports = new CheckBox();
            cbSports.Text = "Sports";
            cbSports.Location = new Point(250, 195);
            cbSports.AutoSize = true;
            Controls.Add(cbSports);

            Label lblCourse = new Label();
            lblCourse.Text = "Course:";
            lblCourse.Location = new Point(40, 240);
            lblCourse.AutoSize = true;
            Controls.Add(lblCourse);

            cmbCourse = new ComboBox();
            cmbCourse.Location = new Point(150, 235);
            cmbCourse.Size = new Size(200, 25);
            cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCourse.Items.AddRange(new object[]
            {
                "BCA", "BBA", "BSc", "MCA"
            });

            Controls.Add(cmbCourse);

            btnRegister = new Button();
            btnRegister.Text = "Register";
            btnRegister.Location = new Point(150, 295);
            btnRegister.Size = new Size(100, 35);
            btnRegister.Click += BtnRegister_Click;
            Controls.Add(btnRegister);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (name == "" || email == "" ||
                cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please enter Name, Email and select Course.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string gender = "Not selected";

            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";

            string hobbies = "";

            if (cbReading.Checked)
                hobbies += "Reading ";

            if (cbSports.Checked)
                hobbies += "Sports ";

            if (hobbies == "")
                hobbies = "None";

            MessageBox.Show(
                "Registration Details\n\n" +
                "Name: " + name + "\n" +
                "Email: " + email + "\n" +
                "Gender: " + gender + "\n" +
                "Hobbies: " + hobbies + "\n" +
                "Course: " + cmbCourse.Text,
                "Registration Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}