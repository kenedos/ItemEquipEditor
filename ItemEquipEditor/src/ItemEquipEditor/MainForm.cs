using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.IO;

namespace ItemEquipEditor
{
    public partial class MainForm : Form
    {
        private XDocument xDoc;
        private XElement currentItem;
        private string filePath = "item_Equip.xml";

        string[] relevantProps = new string[]
        {
            "CT_PATK", "CT_ADD_MATK", "ADD_DEF", "ADD_MDEF", "CRTHR_NT_DS2", "CRTATK_NT_DS2",
            "CRTDR_NT_DS2", "ADD_HR", "ADD_DR", "STR_NT_DS2", "DEX_NT_DS2", "BLK", "BLK_BREAK",
            "CT_ASPD", "CT_MSPD", "CT_KDPow", "CON_NT_DS2", "INT_NT_DS2", "MNA_NT_DS2", "CRTMATK",
            "CT_Aries_NT", "CT_Slash_NT", "CT_Strike_NT", "CT_AriesDEF_NT", "CT_SlashDEF_NT",
            "CT_StrikeDEF_NT", "CT_RES_FIRE", "CT_RES_ICE", "CT_RES_POISON", "CT_RES_LIGHTNING",
            "CT_RES_EARTH", "CT_RES_SOUL", "CT_RES_HOLY", "CT_RES_DARK",
            "ADD_SMALLSIZE_NT_DS2", "ADD_MIDDLESIZE_NT_DS2", "ADD_LARGESIZE_NT_DS2",
            "MHP_NT_DS2", "MSP_NT_DS2", "MSTA_NT_DS2", "RHP_NT_DS2", "RSP_NT_DS2",
            "ADD_FORESTER_NT_DS2", "ADD_WIDLING_NT_DS2", "ADD_VELIAS_NT_DS2", "ADD_PARAMUNE_NT_DS2",
            "ADD_KLAIDA_NT_DS2", "ADD_FIRE_NT_DS2", "ADD_ICE_NT_DS2", "ADD_POISON_NT_DS2",
            "ADD_LIGHTNING_NT_DS2", "ADD_EARTH_NT_DS2", "ADD_SOUL_NT_DS2", "ADD_HOLY_NT_DS2",
            "ADD_DARK_NT_DS2", "LootingChance", "SR_NT_DS2", "SDR_NT_DS2", "CT_OptDesc"
        };

        private Dictionary<string, string> propertyTranslations = new Dictionary<string, string>
        {
            {"CT_PATK", "Physical Attack"},
            {"CT_ADD_MATK", "Magical Attack"},
            {"ADD_DEF", "Defense"},
            {"ADD_MDEF", "M. Defense"},
            {"CRTHR_NT_DS2", "Critical Hit Rate"},
            {"CRTATK_NT_DS2", "Critical Attack"},
            {"CRTDR_NT_DS2", "Critical Defense Rate"},
            {"ADD_HR", "Hit Rate"},
            {"ADD_DR", "Dodge Rate"},
            {"STR_NT_DS2", "STR"},
            {"DEX_NT_DS2", "DEX"},
            {"BLK", "Block"},
            {"BLK_BREAK", "Block Penetration"},
            {"CT_ASPD", "Attack Speed"},
            {"CT_MSPD", "Movement Speed"},
            {"CT_KDPow", "Knockdown Power"},
            {"CON_NT_DS2", "CON"},
            {"INT_NT_DS2", "INT"},
            {"MNA_NT_DS2", "SPR"},
            {"CRTMATK", "Critical Magic Attack"},
            {"CT_Aries_NT", "Piercing"},
            {"CT_Slash_NT", "Slash"},
            {"CT_Strike_NT", "Strike"},
            {"CT_AriesDEF_NT", "Piercing Defense"},
            {"CT_SlashDEF_NT", "Slash Defense"},
            {"CT_StrikeDEF_NT", "Strike Defense"},
            {"CT_RES_FIRE", "Fire Resist"},
            {"CT_RES_ICE", "Ice Resist"},
            {"CT_RES_POISON", "Poison Resist"},
            {"CT_RES_LIGHTNING", "Lightning Resist"},
            {"CT_RES_EARTH", "Earth Resist"},
            {"CT_RES_SOUL", "Soul Resist"},
            {"CT_RES_HOLY", "Holy Resist"},
            {"CT_RES_DARK", "Dark Resist"},
            {"ADD_SMALLSIZE_NT_DS2", "Small Size Attack"},
            {"ADD_MIDDLESIZE_NT_DS2", "Medium Size Attack"},
            {"ADD_LARGESIZE_NT_DS2", "Large Size Attack"},
            {"MHP_NT_DS2", "Max HP"},
            {"MSP_NT_DS2", "Max SP"},
            {"MSTA_NT_DS2", "Max Stamina"},
            {"RHP_NT_DS2", "HP Regen"},
            {"RSP_NT_DS2", "SP Regen"},
            {"ADD_FORESTER_NT_DS2", "Plant Attack"},
            {"ADD_WIDLING_NT_DS2", "Beast Attack"},
            {"ADD_VELIAS_NT_DS2", "Demon Attack"},
            {"ADD_PARAMUNE_NT_DS2", "Mutant Attack"},
            {"ADD_KLAIDA_NT_DS2", "Insect Attack"},
            {"ADD_FIRE_NT_DS2", "Fire Attack"},
            {"ADD_ICE_NT_DS2", "Ice Attack"},
            {"ADD_POISON_NT_DS2", "Poison Attack"},
            {"ADD_LIGHTNING_NT_DS2", "Lightning Attack"},
            {"ADD_EARTH_NT_DS2", "Earth Attack"},
            {"ADD_SOUL_NT_DS2", "Soul Attack"},
            {"ADD_HOLY_NT_DS2", "Holy Attack"},
            {"ADD_DARK_NT_DS2", "Dark Attack"},
            {"LootingChance", "Looting Chance"},
            {"SR_NT_DS2", "AoE Atk Ratio" },
            {"SDR_NT_DS2", "AoE Defense Ratio" },
            {"CT_OptDesc", "Additional Effects" }
        };

        public MainForm()
        {
            InitializeComponent();
            LoadXmlFile();
            InitializeRelevantPropertiesDropdown();
        }

        private void LoadXmlFile()
        {
            xDoc = XDocument.Load(filePath);
        }

        private void InitializeRelevantPropertiesDropdown()
        {
            cmbRelevantProps.Items.Clear();
            foreach (var prop in relevantProps)
            {
                string translatedProp = propertyTranslations.TryGetValue(prop, out string translation) ? translation : prop;
                cmbRelevantProps.Items.Add(new KeyValuePair<string, string>(prop, translatedProp));
            }
            cmbRelevantProps.DisplayMember = "Value";
            cmbRelevantProps.ValueMember = "Key";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string classId = txtClassID.Text;
            currentItem = xDoc.Descendants("Class")
                              .FirstOrDefault(c => c.Attribute("ClassID")?.Value == classId);

            if (currentItem != null)
            {
                DisplayItemProperties();
            }
            else
            {
                MessageBox.Show("Item not found.");
            }
        }

        private void DisplayItemProperties()
        {
            txtUseLv.Text = GetAttributeValue("CT_UseLv");
            txtItemGrade.Text = GetAttributeValue("CT_ItemGrade");
            txtEquipGroup.Text = GetAttributeValue("CT_EquipGroup");
            txtSellPrice.Text = GetAttributeValue("CT_SellPrice");
            txtMaxSocket.Text = GetAttributeValue("CT_MaxSocket_COUNT");

            lstRelevantProps.Items.Clear();
            foreach (var attr in currentItem.Attributes())
            {
                if (IsRelevantProperty(attr.Name.LocalName) && attr.Value != "0")
                {
                    string translatedName = propertyTranslations.TryGetValue(attr.Name.LocalName, out string translation) ? translation : attr.Name.LocalName;
                    lstRelevantProps.Items.Add($"{translatedName}: {attr.Value}");
                }
            }
        }

        private string GetAttributeValue(string attributeName)
        {
            return currentItem.Attribute(attributeName)?.Value ?? "";
        }

        private bool IsRelevantProperty(string propertyName)
        {
            return Array.IndexOf(relevantProps, propertyName) != -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentItem == null)
            {
                MessageBox.Show("Please search for an item first.");
                return;
            }

            UpdateAttribute("CT_UseLv", txtUseLv.Text);
            UpdateAttribute("CT_ItemGrade", txtItemGrade.Text);
            UpdateAttribute("CT_SellPrice", txtSellPrice.Text);
            UpdateAttribute("CT_MaxSocket_COUNT", txtMaxSocket.Text);

            SaveXmlFile();
            MessageBox.Show("Item updated successfully.");
        }

        private void UpdateAttribute(string attributeName, string value)
        {
            var attr = currentItem.Attribute(attributeName);
            if (attr != null)
            {
                attr.Value = value;
            }
            else
            {
                currentItem.Add(new XAttribute(attributeName, value));
            }
        }

        private void btnAddRelevant_Click(object sender, EventArgs e)
        {
            if (currentItem == null)
            {
                MessageBox.Show("Please search for an item first.");
                return;
            }

            if (cmbRelevantProps.SelectedItem == null)
            {
                MessageBox.Show("Please select a relevant property to add.");
                return;
            }

            string selectedProp = ((KeyValuePair<string, string>)cmbRelevantProps.SelectedItem).Key;
            string value = txtRelevantValue.Text;
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Please enter a value for the relevant property.");
                return;
            }

            UpdateAttribute(selectedProp, value);
            DisplayItemProperties();
        }

        private void SaveXmlFile()
        {
            xDoc.Save(filePath);
        }
    }
}