using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace GettingStarted3.Models {
    public class GdpProvider {
        string filepath;

        public GdpProvider(string filepath) {
            this.filepath = filepath;
        }

        public IEnumerable<Gdp> GetGdps() {
            Collection<Gdp> gdps = new Collection<Gdp>();
            XDocument document = XDocument.Load(filepath);
            XElement root = document.Element("G7GDPs");
            foreach(XElement elementGdp in root.Elements("GDP")) {
                gdps.Add(new Gdp(
                    country: elementGdp.Element("Country").Value,
                    year: Convert.ToInt32(elementGdp.Element("Year").Value),
                    product: Convert.ToDouble(elementGdp.Element("Product").Value)));
            }
            return gdps;
        }
    }
}