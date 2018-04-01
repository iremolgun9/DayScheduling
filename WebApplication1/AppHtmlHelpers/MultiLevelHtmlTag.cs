using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.AppHtmlHelpers
{
    public class MultiLevelHtmlTag : TagBuilder
    {
        private readonly IList<MultiLevelHtmlTag> innerTags = new List<MultiLevelHtmlTag>();

        public MultiLevelHtmlTag(string tagName) : base(tagName)
        {
        }

        public IEnumerable<MultiLevelHtmlTag> InnerTags
        {
            get
            {
                return new ReadOnlyCollection<MultiLevelHtmlTag>(this.innerTags);
            }
        }
        public void Add(MultiLevelHtmlTag tag)
        {
            if (tag == null)
            {
                throw new ArgumentNullException("tag");
            }

            this.innerTags.Add(tag);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var tag in this.innerTags)
            {
                sb.Append(tag.ToString());
            }

            this.InnerHtml = sb.ToString();
            return base.ToString();
        }
    }
}