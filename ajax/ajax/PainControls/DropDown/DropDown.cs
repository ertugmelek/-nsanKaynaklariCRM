using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Globalization;

[assembly: WebResource("PainControls.DropDown.DropDown.js", "application/x-javascript")]
[assembly: WebResource("PainControls.DropDown.DropDown.css", "text/css",PerformSubstitution=true)]
[assembly: WebResource("PainControls.DropDown.menuOutPut.gif", "image/gif")]
[assembly: WebResource("PainControls.DropDown.menuLi.gif", "image/gif")]

/////////////We need set the these files as Embedded Resource //////////////
namespace PainControls
{

    public class DropDown : ListControl, IScriptControl,IPostBackDataHandler,INamingContainer
    {
        public DropDown()
        {

        }

        #region IScriptControl Member
        private string GetClientID(string controlId)
        {
            return this.FindControl(controlId).ClientID;
        }

        public IEnumerable<ScriptDescriptor> GetScriptDescriptors()
        {
            ScriptControlDescriptor descriptor = new ScriptControlDescriptor("PainControls.DropDown", this.ClientID);
            descriptor.AddElementProperty("dropDownOutPutElement", DropDownOutPutElement.ClientID);
            descriptor.AddElementProperty("dropDownListElement", DropDownListElement.ClientID);
            descriptor.AddElementProperty("dropDownOptionList", DropDownOptionList.ClientID);
            descriptor.AddElementProperty("dropDownHiddenField", DropDownHiddenField.ClientID);

            descriptor.AddProperty("autoPostBack", AutoPostBack);
            descriptor.AddProperty("selectedIndex", SelectedIndex);
            descriptor.AddProperty("listItemHighLightCssClass", ListItemHighLightCssClass);
            descriptor.AddProperty("listItemCssClass", ListItemCssClass);
       
            

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //In render phase, it will render to $create function according to this method. In $create function, 
            //1.Call Constrction function: it will build the instance of Type on client, and call the construction function of Type. 
            //2.Set Property/ElementProperty/Event/Reference: 
            // For setting property, it will call Sys$Component$_setProperties to set the elementproperty and property according to the set_property and get_property function.
            // So we have to prepare set/get client function to retrieve the property objects.
            // For Event, it will follow the add_event/remove_event rule, so we need prepare the rule functions for it.
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            yield return descriptor;
        }

        // Generate the script reference
        public IEnumerable<ScriptReference> GetScriptReferences()
        {
            yield return new ScriptReference(Page.ClientScript.GetWebResourceUrl(this.GetType(), "PainControls.DropDown.DropDown.js"));
        }
        #endregion

        #region Css Property

        public virtual string ListItemHighLightCssClass
        {
            get
            {
                return "listItemHighLight";
            }
        }

        public virtual string ListItemCssClass
        {
            get
            {
                return "listItem";
            }
        }

        #endregion

        #region List Properties

        public override int SelectedIndex
        {
            get
            {
                int selectedIndex = base.SelectedIndex;
                if ((selectedIndex < 0) && (this.Items.Count > 0))
                {
                    this.Items[0].Selected = true;
                    selectedIndex = 0;
                }
                return selectedIndex;
            }
            set
            {
                base.SelectedIndex = value;
                DropDownHiddenField.Value = value.ToString();

            }
        }

        public override bool AutoPostBack
        {
            get
            {
                return base.AutoPostBack;
            }
            set
            {
                base.AutoPostBack = value;
            }
        }

        #endregion

        #region Child Controls

        private HtmlGenericControl _DropDownOutPutElement;
        private HtmlGenericControl _DropDownListElement;
        private BulletedList _DropDownOptionList;
        private HiddenField _DropDownHiddenField;
        protected virtual HtmlGenericControl DropDownOutPutElement
        {
            get
            {
                if (_DropDownOutPutElement == null)
                    _DropDownOutPutElement = new HtmlGenericControl("Div");

                return _DropDownOutPutElement;
            } 
        }

        protected virtual HtmlGenericControl DropDownListElement
        {
            get
            {
                if (_DropDownListElement == null)
                    _DropDownListElement = new HtmlGenericControl("Div");
                return _DropDownListElement;
            }
        }
        protected virtual BulletedList DropDownOptionList
        {
            get
            {
                if (_DropDownOptionList == null)

                    _DropDownOptionList = new BulletedList();

                return _DropDownOptionList;
            }
        }
        protected virtual HiddenField DropDownHiddenField
        {
            get
            {
                if (_DropDownHiddenField == null)
                    _DropDownHiddenField = new HiddenField();
                return _DropDownHiddenField;
            }
        }
        #endregion

        #region Create Child Controls

        protected override void CreateChildControls()
        {        

            this.Controls.Clear();
            CreateDropDownOutPutElement();
            CreateDropDownListElement();
            CretaeDropDownOptionList();
            CreateDropDownHiddenField();
            base.CreateChildControls();
            
        }

        private void CreateDropDownOutPutElement()
        {
          
            this.Controls.Add(DropDownOutPutElement);
        }
        private void CreateDropDownListElement()
        {
 
            DropDownListElement.Style.Add(HtmlTextWriterStyle.Display, "none");
            this.Controls.Add(DropDownListElement);
        }
        private void CretaeDropDownOptionList()
        {

            DropDownListElement.Controls.Add(DropDownOptionList);
        }
        private void CreateDropDownHiddenField()
        {
            DropDownListElement.Controls.Add(DropDownHiddenField);
        }

        #endregion

        #region Render Methods

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            base.AddAttributesToRender(writer);
            AddDropDownOutPutElementAttributesToRender(writer);
            AddDropDownListElementAttributesToRender(writer);
            AddDropDownOptionListAttributesToRender(writer); 
        }

        protected virtual void AddDropDownOutPutElementAttributesToRender(HtmlTextWriter writer)
        {
            //DropDownOutPutElement.ID = this.ClientID + "_DropDownOutPutElement";
            DropDownOutPutElement.InnerHtml = this.Items[SelectedIndex].Text;
            DropDownOutPutElement.Attributes.Add("class", "dropDownOutPutElement");
        }

        protected virtual void AddDropDownListElementAttributesToRender(HtmlTextWriter writer)
        {
            //DropDownListElement.ID = this.ClientID + "_DropDownListElement";
            DropDownListElement.Attributes.Add("class", "dropDownListElement");
        }

        protected virtual void AddDropDownOptionListAttributesToRender(HtmlTextWriter writer)
        {
            //DropDownOptionList.ID = this.ClientID + "_DropDownOptionList";
            DropDownOptionList.CssClass = "dropDownOptionList";
        }


        protected override HtmlTextWriterTag TagKey
        {
            get { return HtmlTextWriterTag.Div; }
        }


        // Add Css reference 
        private void RenderCssReference()
        {
            string cssUrl = Page.ClientScript.GetWebResourceUrl(this.GetType(), "PainControls.DropDown.DropDown.css");

            HtmlLink link = new HtmlLink();
            link.Href = cssUrl;
            link.Attributes.Add("type", "text/css");
            link.Attributes.Add("rel", "stylesheet");
            Page.Header.Controls.Add(link);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            RenderCssReference();
   

            //////////////////////////We need register ScriptControl in building ScriptControl in PreRender phase.//////////////////////////
            ScriptManager manager = ScriptManager.GetCurrent(this.Page);
            if (manager == null)
            {
                throw new InvalidOperationException("A ScriptManager is required on the page.");
            }
            manager.RegisterScriptControl<DropDown>(this);
            Page.RegisterRequiresPostBack(this);


        }
        protected override void RenderContents(HtmlTextWriter writer)
        {
            //////////////////////////We need regiser ScriptDescriptors in building ScriptControl in Render phase.//////////////////////////
            ScriptManager.GetCurrent(this.Page).RegisterScriptDescriptors(this);
      
            DropDownOutPutElement.RenderControl(writer);

            DropDownOptionList.Items.Clear();
            ListItem[] copy = new ListItem[Items.Count];
            Items.CopyTo(copy, 0);
            DropDownOptionList.Items.AddRange(copy);

            DropDownListElement.RenderControl(writer);
            DropDownHiddenField.RenderControl(writer);

        }
       
        #endregion

        #region IPostBackDataHandler Implementation
     

        bool IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection)
        {
            return LoadPostData(postDataKey, postCollection);
        }

        void IPostBackDataHandler.RaisePostDataChangedEvent()
        {
            RaisePostDataChangedEvent();
        }

        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection)
        {
            if (!Enabled)
                return false;

            int newSelectedIndex = Convert.ToInt32(postCollection.GetValues(DropDownHiddenField.UniqueID)[0], CultureInfo.InvariantCulture);
            EnsureDataBound();

            if (newSelectedIndex != SelectedIndex)
            {
 
                SelectedIndex = newSelectedIndex;
                return true;
            }
            
            return false;
        }

        public virtual void RaisePostDataChangedEvent()
        {
            this.OnSelectedIndexChanged(EventArgs.Empty);
        }

        #endregion


    }
}