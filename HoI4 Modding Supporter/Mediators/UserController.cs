﻿using HoI4_Modding_Supporter.Workers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HoI4_Modding_Supporter.Mediators
{
    class UserController
    {
        /// <summary>
        /// Main.csの入力チェック
        /// </summary>
        public int MainGenerateChecker(List<TextBox> textBoxes, List<ComboBox> comboBoxes, List<CheckBox> checkBoxes)
        {
            return InputChecker.MainGenrateChecker(textBoxes, comboBoxes, checkBoxes);
        }

        /// <summary>
        /// FactionSettings.csの入力チェック
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <returns></returns>
        public int FactionSettingsChecker(List<TextBox> textBoxes)
        {
            return InputChecker.FactionSettingsChecker(textBoxes);
        }

        /// <summary>
        /// NationalLeaderSettings.csの入力チェック
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <param name="richTextBoxes"></param>
        /// <param name="comboBoxes"></param>
        /// <returns></returns>
        public int NationalLeaderSettingsChecker(List<TextBox> textBoxes, List<RichTextBox> richTextBoxes, List<ComboBox> comboBoxes)
        {
            return InputChecker.NationalLeaderSettingsChecker(textBoxes, richTextBoxes, comboBoxes);
        }

        /// <summary>
        /// CustomIdeologiesSettings.csの入力チェック
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <returns></returns>
        public int CustomIdeologiesSettingsChecker(List<TextBox> viewNameTextBoxList,
                                                   List<TextBox> eventViewNameTextBoxList,
                                                   List<TextBox> aliasNameTextBoxList,
                                                   List<TextBox> partyFullNameTextBoxList,
                                                   List<TextBox> partyAliasNameTextBoxList,
                                                   List<TextBox> bigFlagPathTextBoxList,
                                                   List<TextBox> mediumFlagPathTextBoxList,
                                                   List<TextBox> smallFlagPathTextBoxList)
        {
            return InputChecker.CustomIdeologiesSettingsChecker(viewNameTextBoxList,
                                                      eventViewNameTextBoxList,
                                                      aliasNameTextBoxList,
                                                      partyFullNameTextBoxList,
                                                      partyAliasNameTextBoxList,
                                                      bigFlagPathTextBoxList,
                                                      mediumFlagPathTextBoxList,
                                                      smallFlagPathTextBoxList);
        }
    }
}
