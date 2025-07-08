using System;
using System.Windows;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Users
{
    /// <summary>
    /// Stub ChangePassword class for compilation
    /// The original ChangePassword.cs has been excluded due to compilation errors
    /// </summary>
    public partial class ChangePassword : Window
    {
        public User User { get; set; }
        public bool IsPasswordChangedSuccessful { get; set; }

        public ChangePassword()
        {
            InitializeComponent();
            IsPasswordChangedSuccessful = false;
        }

        private void InitializeComponent()
        {
            this.Title = "Change Password - Stub";
            this.Width = 400;
            this.Height = 300;
        }

        public void Show()
        {
            base.Show();
        }

        public new void ShowDialog()
        {
            base.ShowDialog();
        }
    }
}
