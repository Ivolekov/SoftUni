using System;
using System.Text;

namespace HTMLDispatcher
{
    class ElementBuilder
    {
        private string element;
        private string fullElement;
        private string atribute;
        private string value;
        private string content;

        private string Element
        {
            get { return this.element; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                this.element = value.Trim();
            }
        }
        private string FullElement
        {
            get { return this.fullElement; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                if (value.Contains("<"))
                    this.fullElement = value;
                else
                    this.fullElement = "<" + value.Trim() + @"><\" + value.Trim() + ">";
            }
        }
        private string Atribute
        {
            get { return this.atribute; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                this.atribute = value.Trim();
            }
        }
        private string Value
        {
            get { return this.value; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                this.value = value.Trim();
            }
        }
        private string Content
        {
            get { return this.content; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                this.content = value.Trim();
            }
        }

        public ElementBuilder(string elementName)
        {
            this.Element = elementName;
            this.FullElement = this.Element;
        }

        public void AddAtribute(string atribute, string value)
        {
            this.Atribute = atribute;
            this.Value = value;
            string[] line = this.FullElement.Split('>');
            StringBuilder str = new StringBuilder();
            str.Append(line[0]);
            str.Append(String.Format(" {0}=\"{1}\"", this.Atribute, this.Value));
            str.Append(">");
            str.Append(line[1]);
            str.Append(">");
            this.FullElement = str.ToString();
        }

        public void AddContent(string content)
        {
            this.Content = content;
            string[] line = this.FullElement.Split('>');
            StringBuilder str = new StringBuilder();
            str.Append(line[0]);
            str.Append(">");
            str.Append(this.Content);
            str.Append(line[1]);
            str.Append(">");
            this.FullElement = str.ToString();
        }

    }
}
