using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public interface TileDescription
    {
        string GetDescription();
    }
    public class basicDescription : TileDescription
    {
        private string MyDescription { get; set; }
        public basicDescription(string myDescription = "there is nothing in this space")
        {
            MyDescription = myDescription;
        }

        public string GetDescription()
        {
            return MyDescription;
        }
    }
    public class UpdateableDescription : TileDescription
    {
        private string MyDescription { get; set; }
        public UpdateableDescription(string myDescription = "there is nothing in this space")
        {
            MyDescription = myDescription;
        }

        public string GetDescription()
        {
            return MyDescription;
        }
        public void updateDescription(string newDescription)
        {
            MyDescription = newDescription;
        }
    }
}
