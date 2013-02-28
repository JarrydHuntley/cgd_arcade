using CGDArcade_CommonLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CGDArcade_WPF
{
    public class ArcadeEntryManager
    {
        public List<GenericArcadeEntity> arcadeEntities;

        public ArcadeEntryManager()
        {
            this.arcadeEntities = new List<GenericArcadeEntity>();

            //TODO NEED TO INTERFACE TO DB HERE
            LoadTestData();
        }

        private void LoadTestData()
        {
            string exepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); 
            exepath += "\\TestData\\Images";

            string[] filePaths = Directory.GetFiles(@exepath);

            foreach (string filepath in filePaths)
            {
                GenericArcadeEntity newEntry = new GenericArcadeEntity();
                newEntry.entityTitle = Path.GetFileName(@filepath);
                newEntry.SetSelectionControlMedia(@filepath, "IMAGE");

                this.arcadeEntities.Add(newEntry);
            }            
        }




    }
}
