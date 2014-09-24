using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_2
{
    class ElementBuilder
    {
        private string tag;
        private string content;
        private string value;
        private int multiplier = 1;
        Dictionary<string, string> Attributes = new Dictionary<string, string>();
        public ElementBuilder(HTMLTag tag)
        {
            if (tag == HTMLTag.a)
            {
                this.tag = "a";
            }
            if (tag == HTMLTag.img)
            {
                this.tag = "img";
            }
            if (tag == HTMLTag.input)
            {
                this.tag = "input"; 
            }
        }

        public ElementBuilder()
        {
        }
        private void setValues()
        {
            string attributes = "";
            foreach (KeyValuePair<string,string> str in Attributes.ToArray())
            {
                attributes += "\"" + str.Key +"\"=" + "\""+ str.Value +"\"";
            }
            string current = "<" + this.tag + Attributes.ToString() + ">" + this.content + "</" + this.tag + ">";
            for (int i = 0; i < this.multiplier; i++)
            {
                this.value += current;
            }
        }
        public void AddAttribute(string param, string val)
        {
            this.Attributes.Add(param,val);
        }

        public void AddContent(string Content)
        {
            this.content += Content;
        }
        public enum HTMLTag
        {
            img,a,input
        }
    }

    static class HTMLDispatcher
    {
        static ElementBuilder CreateImage(string src, string title)
        {
            ElementBuilder e = new ElementBuilder(ElementBuilder.HTMLTag.img);
            e.AddAttribute("src", src);
            e.AddAttribute("title", title);
            return e;
        }

        static ElementBuilder CreateImage(string src, string alt, string title)
        {
            ElementBuilder e = new ElementBuilder(ElementBuilder.HTMLTag.img);
            e.AddAttribute("src", src);
            e.AddAttribute("alt", alt);
            e.AddAttribute("title", title);
            return e;
        }

        static ElementBuilder CreateURL(string url, string title, string text)
        {

            ElementBuilder e = new ElementBuilder(ElementBuilder.HTMLTag.a);
            e.AddAttribute("href", url);
            e.AddAttribute("title", title);
            e.AddContent(text);
            return e;
        }

        static ElementBuilder CreateInput(string type, string name, string value)
        {
            ElementBuilder e = new ElementBuilder(ElementBuilder.HTMLTag.a);
            e.AddAttribute("type", type);
            e.AddAttribute("name", name);
            e.AddContent(value);
            return e;
        }
    }
}
