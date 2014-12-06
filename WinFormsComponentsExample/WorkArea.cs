using System.Collections.Generic;

namespace WinFormsComponentsExample
{
    public class WorkArea
    {
        private List<ChartPicture> pictures = new List<ChartPicture>();

        private static WorkArea instance;

        private WorkArea()
        {
        }

        public static WorkArea Instance()
        {
            if (instance == null)
                instance = new WorkArea();
            return instance;
        }

        public List<ChartPicture> Pictures
        {
            get { return pictures; }
        }

        public void AddPicture(ChartPicture picture)
        {
            pictures.Add(picture);
        }
    }
}