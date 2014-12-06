using System;
using System.Collections.Generic;
using System.Text;

namespace iTadApp
{
    public class AgendaItem
    {
        public string Title { get; set; }
        public string Prelegent { get; set; }
        
        public AgendaItem(string title, string prelegent)
        {
            Title = title;
            Prelegent = prelegent;
        }
    }

}
