using System.Collections.Generic;

namespace WinFormsComponentsExample
{
    public class WorkArea
    {
        private List<ChartPicture> pictures = new List<ChartPicture>();

        private static WorkArea _instance;

        private WorkArea()
        {
        }

        public static WorkArea Instance()
        {
            if (_instance == null)
                _instance = new WorkArea();
            return _instance;
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