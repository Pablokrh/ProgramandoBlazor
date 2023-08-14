namespace DataGrid.Controls
{
    public class PaginConfig
    {
        public bool Enabled { get; set; }
        
        public int PageSize { get; set; }

        public bool CustomPager { get; set; }

        public int NumOfItemsToSkip (int pageNumber)
        {
            if (Enabled)
            {
                return (pageNumber - 1)*PageSize;
            }
            //Acá hay un else implícito:
            return 0;
        }

        public int NumOfItemsToTake (int totalItems)
        {
            if (Enabled)
            {
                return PageSize;
            }
            return totalItems;
        }

        //IR A LA PRÓXIMA O ANTERIOR PÁGINA
        public int PrevPageNumber (int currentPageNumber)
        {
            if (currentPageNumber > 1)
            {
                return (currentPageNumber - 1);
            }
            else return 1;

        }
        public int NextPageNumber(int currentPageNumber, int totalItemsCount)
        {
            if (currentPageNumber < MaxPageNumber(totalItemsCount))
            {
                return (currentPageNumber + 1);
            }
            else return currentPageNumber;

        }

        public int MaxPageNumber(int totalItemsCount)
        {
            int maxPageNumber;
            double numberOfPages = (double)totalItemsCount / PageSize;
            if (numberOfPages ==Math.Floor(numberOfPages))
            {
                maxPageNumber = (int)numberOfPages;
            }
            else
            {
                maxPageNumber = (int)numberOfPages + 1;
            }
            return maxPageNumber;
        }


    }
}
