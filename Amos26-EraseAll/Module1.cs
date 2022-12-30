using Amos;
using Microsoft.VisualBasic;

namespace Amos26_EraseAll
{

    [System.ComponentModel.Composition.Export(typeof(IPlugin))]
    public class CustomCode : IPlugin
    {

        // This plugin was updated 2022 and converted into C# by Joseph Steed

        public string Name()
        {
            return "Erase All";
        }

        public string Description()
        {
            return "Erases everything in the model.";
        }

        public int MainSub()
        {
            var allVariables = new System.Collections.Generic.List<int>();
            var removeVariables = new Collection();
            
            foreach (PDElement variable in pd.PDElements) {
                allVariables.Add(variable.MyIndex);
            }
            allVariables.Sort();
            for (int i = allVariables.Count - 1; i >= 0; i--)
            {
                pd.EditErase(allVariables[i]);
            }
           // foreach (int variable in allVariables){ 
            //    pd.EditErase(variable);
            //}


            return default;

        }

    }
}