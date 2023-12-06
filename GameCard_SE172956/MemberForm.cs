using Repositories.Models;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCard_SE172956
{
    public partial class MemberForm : Form
    {
        private GameCardInfoService  gamecardService = new GameCardInfoService();
        private ProviderService providerService = new ProviderService();
        private MemberAccount member;
        public MemberForm(MemberAccount b)
        {
            InitializeComponent();
            member = b;
            string fullName = b.MemberFullName;
            int? role = b.Role;
            string roleName;

            switch (role)
            {
                case 1:
                    roleName = "Admin";
                    break;
                case 2:
                    roleName = "Staff";
                    break;
                case 3:
                    roleName = "Member";
                    break;
                default:
                    roleName = "Anonymous";
                    break;
            }

            lblUserNameAndRole.Text = fullName + " | " + roleName;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            var result = gamecardService.GetAllGameCardInfo();

            var displayList = result.Select(sunglass => new
            {
                sunglass.GameCardId,
                sunglass.GameCardName,
                sunglass.GameDescription,
                sunglass.GamePlatform,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ProviderId,
                ProviderName = sunglass.Provider?.ProviderName
            }).ToList();

            dgvGamecardList.DataSource = null;
            dgvGamecardList.DataSource = displayList;

            cboProvider.DataSource = providerService.GetAllProviders();
            cboProvider.DisplayMember = "ProviderName";
            cboProvider.ValueMember = "ProviderId";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = gamecardService.SearchGameCardInfo(txtKeyword.Text.Trim());

            if (result.Count == 0)
            {
                MessageBox.Show("Cannot find the result!!!",
                    "Search keyword cannot find",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var displayList = result.Select(sunglass => new
            {
                sunglass.GameCardId,
                sunglass.GameCardName,
                sunglass.GameDescription,
                sunglass.GamePlatform,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ProviderId,
                ProviderName = sunglass.Provider?.ProviderName
            }).ToList();

            dgvGamecardList.DataSource = null;
            dgvGamecardList.DataSource = displayList;

            cboProvider.DataSource = providerService.GetAllProviders();
            cboProvider.DisplayMember = "ProviderName";
            cboProvider.ValueMember = "ProviderId";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
