/// <reference name="MicrosoftAjax.js"/>


Type.registerNamespace("PainControls");

PainControls.DropDown = function(element) {
    PainControls.DropDown.initializeBase(this, [element]);
    //element property 
    this._dropDownOutPutElement = null;
    this._dropDownListElement = null;
    this._dropDownOptionList = null;
    this._dropDownHiddenField = null;
    //property
    this._autoPostBack = null;
    this._selectedIndex = null;
    this._listItemHighLightCssClass=null;
    this._listItemCssClass=null;

    //handler
    this._outPutClickHandler = null;
    this._outPutMouseOverHandler = null;
    this._outPutMouseOutHandler = null;
    this._listMouseOverHandler = null;
    this._listMouseDownHandler = null;
    
    //
    this._highlightedIndex=null;
    this._dropDownOutPutElementBorderColor=null;
    this._isShown=null;
}

PainControls.DropDown.prototype = {
    initialize: function() {
        PainControls.DropDown.callBaseMethod(this, 'initialize');
        this.initializeListItems();
        this.createDelegates();
        this.createHandlers();
      

    },
    
    initializeListItems:function(){
        var children = this.get_dropDownOptionList().childNodes;
        for (var i = 0; i < children.length; ++i) {

            Sys.UI.DomElement.addCssClass(children[i],this.get_listItemCssClass());     
        }
    },

    dispose: function() {
        this.clearHandlers();
        this.clearDelegates();    
        PainControls.DropDown.callBaseMethod(this, 'dispose');

    },
    
    createDelegates:function(){
        this._outPutClickHandler = Function.createDelegate(this, this._onOutPutClick);
        this._outPutMouseOverHandler = Function.createDelegate(this, this._onOutPutMouseOver);
        this._outPutMouseOutHandler = Function.createDelegate(this, this._onOutPutMouseOut);
        this._listMouseOverHandler = Function.createDelegate(this, this._onListMouseOver);
        this._listMouseDownHandler = Function.createDelegate(this, this._onListMouseDown);

    },

    clearDelegates:function(){
        this._outPutClickHandler = null;
        this._outPutMouseOverHandler = null;
        this._outPutMouseOutHandler = null;
        this._listMouseOverHandler = null;
        this._listMouseDownHandler = null;

    },

    createHandlers:function(){

        $addHandlers(this.get_dropDownOutPutElement(),
        {
            'click': this._outPutClickHandler,
            'mouseover': this._outPutMouseOverHandler,
            'mouseout': this._outPutMouseOutHandler
        }, this);

        $addHandlers(this.get_dropDownOptionList(),
        {
            'mouseover': this._listMouseOverHandler,
            'mousedown': this._listMouseDownHandler,

        }, this);
    },

    clearHandlers:function(){
        $clearHandlers(this.get_dropDownOutPutElement());
        $clearHandlers(this.get_dropDownOptionList());
    },

    _showListElement: function() {

        var loc = Sys.UI.DomElement.getLocation(this._dropDownOutPutElement);
        Sys.UI.DomElement.setLocation(this._dropDownListElement, loc.x, loc.y + this._dropDownOutPutElement.offsetHeight);
        this._dropDownListElement.style.display = "block";
        this._isShown=true;
    },
    
    _hideListElement:function(){
        this._dropDownListElement.style.display = "none";
        this._isShown=false;
    },


    //event handler
    _onOutPutClick: function(e) {
        if(this._isShown)
            this._hideListElement();
        else
            this._showListElement();
        e.preventDefault();
        return false;
    },

    _onOutPutMouseOver: function(e) {
        //
        this._dropDownOutPutElementBorderColor=this.get_dropDownOutPutElement().style.borderColor;
        this.get_dropDownOutPutElement().style.borderColor="#F7A040";

    },

    _onOutPutMouseOut: function(e) {
        //
        if(this._dropDownOutPutElementBorderColor!=null)
            this.get_dropDownOutPutElement().style.borderColor=this._dropDownOutPutElementBorderColor;
    },

    _onListMouseOver: function(e) {
        //
        if (e.target !== this.get_dropDownOptionList()) {
            var target = e.target;
            var children = this.get_dropDownOptionList().childNodes;

            // loop through children to find a match with the target
            for (var i = 0; i < children.length; ++i) {
                // match found, highlight item and break loop
                if (target === children[i]) {
                    this._highlightListItem(i, true);
                    break;
                }
            }
        }
        
    },

    _onListMouseDown: function(e) {

        if (e.target == this.get_dropDownOptionList() || e.target.tagName == 'scrollbar') {
            return true;
        }

        // set the TextBox to the highlighted ListItem's text and update selectedIndex
        if (e.target !== this.get_dropDownOptionList()) {
            if(this.get_selectedIndex() != this._highlightedIndex){
                var highlightedItem = this.get_dropDownOptionList().childNodes[this._highlightedIndex];             
                var text = this.get_listItems()[this._highlightedIndex].text;
                this.get_dropDownOutPutElement().innerHTML = text;
                this.set_selectedIndex(this._highlightedIndex);

                
                // return focus to the TextBox
                this.get_dropDownOutPutElement().focus();                       
                
                if(this.get_autoPostBack())
                {
                    __doPostBack(this.get_element().id, '');
            
                }
            }
            this._hideListElement(); 
        }
        else {
            return true;
        }
        e.preventDefault();
        e.stopPropagation();
        return false;
    },

    _highlightListItem: function(index, isHighLighted){
            // only highlight valid indices
        if (index == undefined || index < 0) {
            if (this._highlightedIndex != undefined && this._highlightedIndex >= 0) {
                this._highlightListItem(this._highlightedIndex, false);
            }
            return;
        }
        var children = this.get_dropDownOptionList().childNodes;
        var newLiElement = children[index];
        var oldLiElement = this._highlightedIndex==null?null: children[this._highlightedIndex];
        
        if(oldLiElement!=null)
            this._toggleCssClass(oldLiElement,this.get_listItemCssClass(),this.get_listItemHighLightCssClass());
        this._toggleCssClass(newLiElement,this.get_listItemCssClass(),this.get_listItemHighLightCssClass());     
        
        this._highlightedIndex=index;
        
        
    },
    
    _toggleCssClass: function(element,cssClassName1,cssClassName2){
    
        var oldClassName=element.className;
        if(oldClassName!=cssClassName1 && oldClassName!=cssClassName2)
            return;
        var newClassName=(oldClassName==cssClassName1)?cssClassName2:cssClassName1;
        Sys.UI.DomElement.removeCssClass(element,oldClassName);
        Sys.UI.DomElement.addCssClass(element,newClassName);
    },

    //property
    get_autoPostBack: function() {
        return this._autoPostBack;
    },

    set_autoPostBack: function(val) {
        if (this._autoPostBack !== val) {
            this._autoPostBack = val;
            this.raisePropertyChanged('autoPostBack');
        }
    },
    get_selectedIndex: function() {
        this._ensureSelectedIndex();
        var selectedIndex = this.get_dropDownHiddenField().value;
        return parseInt(selectedIndex);
    },

    set_selectedIndex: function(val) {
        if (this.get_dropDownHiddenField().value !== val.toString()) {
            this.get_dropDownHiddenField().value = val.toString();
            this._ensureSelectedIndex();
            this.raisePropertyChanged('selectedIndex');
        }
    },

    _ensureSelectedIndex: function() {

        // server may not always invoke set_selectedIndex(), need to make sure this is always an integer
        var selectedIndex = this.get_dropDownHiddenField().value;
        if (selectedIndex == '') {
            selectedIndex = this.get_listItems().count > 0 ? 0 : -1;
            this.get_dropDownHiddenField().value = selectedIndex.toString();
        }
    },
    
    get_listItemHighLightCssClass:function(){
        return this._listItemHighLightCssClass;
    },
    
    set_listItemHighLightCssClass:function(val){
        if (this._listItemHighLightCssClass !== val) {
            this._listItemHighLightCssClass = val;
            this.raisePropertyChanged('listItemHighLightCssClass');
        }
    },
    
    get_listItemCssClass:function(){
        return this._listItemCssClass;
    },
    
    set_listItemCssClass:function(val){
        if (this._listItemCssClass !== val) {
            this._listItemCssClass = val;
            this.raisePropertyChanged('listItemCssClass');
        }
    },
    
    get_listItems: function() {
        var items = new Array();
        var childNodes = this.get_dropDownOptionList().childNodes;
        for (var i = 0; i < childNodes.length; i++) {
            var obj = new Object();
            obj.text = childNodes[i].innerHTML.trim();
            Array.add(items,obj);
        }
        return items;

    },

    get_dropDownOutPutElement: function() {
        return this._dropDownOutPutElement;
    },

    set_dropDownOutPutElement: function(val) {
        if (this._dropDownOutPutElement !== val) {
            this._dropDownOutPutElement = val;
            this.raisePropertyChanged('dropDownOutPutElement');
        }
    },

    get_dropDownListElement: function() {
        return this._dropDownListElement;
    },

    set_dropDownListElement: function(val) {
        if (this._dropDownListElement !== val) {
            this._dropDownListElement = val;
            this.raisePropertyChanged('dropDownListElement');
        }
    },

    get_dropDownOptionList: function() {
        return this._dropDownOptionList;
    },

    set_dropDownOptionList: function(val) {
        if (this._dropDownOptionList !== val) {
            this._dropDownOptionList = val;
            this.raisePropertyChanged('dropDownOptionList');
        }
    },

    get_dropDownHiddenField: function() {
        return this._dropDownHiddenField;
    },

    set_dropDownHiddenField: function(val) {
        if (this._dropDownHiddenField !== val) {
            this._dropDownHiddenField = val;
            this.raisePropertyChanged('dropDownHiddenField');
        }
    },



}
PainControls.DropDown.registerClass('PainControls.DropDown', Sys.UI.Control);

if (typeof (Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();