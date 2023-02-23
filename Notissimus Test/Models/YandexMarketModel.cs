using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Notissimus_Test.Models
{
    // NOTE: Code generated from XML by Visual Studio (Paste XML as Classes)
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class yml_catalog
    {

        private yml_catalogShop shopField;

        private string dateField;

        /// <remarks/>
        public yml_catalogShop shop
        {
            get
            {
                return this.shopField;
            }
            set
            {
                this.shopField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShop
    {

        private string nameField;

        private string companyField;

        private string urlField;

        private yml_catalogShopCurrencies currenciesField;

        private yml_catalogShopCategory[] categoriesField;

        private ushort local_delivery_costField;

        private yml_catalogShopOffer[] offersField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public yml_catalogShopCurrencies currencies
        {
            get
            {
                return this.currenciesField;
            }
            set
            {
                this.currenciesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("category", IsNullable = false)]
        public yml_catalogShopCategory[] categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }

        /// <remarks/>
        public ushort local_delivery_cost
        {
            get
            {
                return this.local_delivery_costField;
            }
            set
            {
                this.local_delivery_costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("offer", IsNullable = false)]
        public yml_catalogShopOffer[] offers
        {
            get
            {
                return this.offersField;
            }
            set
            {
                this.offersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopCurrencies
    {

        private yml_catalogShopCurrenciesCurrency currencyField;

        /// <remarks/>
        public yml_catalogShopCurrenciesCurrency currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopCurrenciesCurrency
    {

        private string idField;

        private byte rateField;

        private byte plusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte plus
        {
            get
            {
                return this.plusField;
            }
            set
            {
                this.plusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopCategory
    {

        private byte idField;

        private byte parentIdField;

        private bool parentIdFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte parentId
        {
            get
            {
                return this.parentIdField;
            }
            set
            {
                this.parentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parentIdSpecified
        {
            get
            {
                return this.parentIdFieldSpecified;
            }
            set
            {
                this.parentIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopOffer
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private int idField;

        private string typeField;

        private int bidField;

        private int cbidField;

        private bool cbidFieldSpecified;

        private bool availableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ISBN", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("artist", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("author", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("binding", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("categoryId", typeof(yml_catalogShopOfferCategoryId))]
        [System.Xml.Serialization.XmlElementAttribute("country", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("country_of_origin", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("currencyId", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("dataTour", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("date", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("days", typeof(int))]
        [System.Xml.Serialization.XmlElementAttribute("delivery", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("director", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("downloadable", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("format", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("hall", typeof(yml_catalogShopOfferHall))]
        [System.Xml.Serialization.XmlElementAttribute("hall_part", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("hotel_stars", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("included", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("is_kids", typeof(int))]
        [System.Xml.Serialization.XmlElementAttribute("is_premiere", typeof(int))]
        [System.Xml.Serialization.XmlElementAttribute("language", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("local_delivery_cost", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("manufacturer_warranty", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("meal", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("media", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("model", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("originalName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("page_extent", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("part", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("performance_type", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("performed_by", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("picture", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("place", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("price", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("publisher", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("recording_length", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("region", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("room", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("series", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("starring", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("storage", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("transport", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("typePrefix", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("url", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vendor", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vendorCode", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("volume", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("worldRegion", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("year", typeof(ushort))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int bid
        {
            get
            {
                return this.bidField;
            }
            set
            {
                this.bidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int cbid
        {
            get
            {
                return this.cbidField;
            }
            set
            {
                this.cbidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cbidSpecified
        {
            get
            {
                return this.cbidFieldSpecified;
            }
            set
            {
                this.cbidFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool available
        {
            get
            {
                return this.availableField;
            }
            set
            {
                this.availableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopOfferCategoryId
    {
        [XmlIgnore]
        public int ID { get; set; }

        private string typeField;

        private int valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public int Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopOfferHall
    {
        [XmlIgnore]
        public int ID { get; set; }
        
        private string planField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string plan
        {
            get
            {
                return this.planField;
            }
            set
            {
                this.planField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        [Display(Name = "ISBN")]
        ISBN,

        /// <remarks/>
        [Display(Name = "Artist")]
        artist,

        /// <remarks/>
        [Display(Name = "Author")]
        author,

        /// <remarks/>
        [Display(Name = "Book format")]
        binding,

        /// <remarks/>
        [Display(Name = "Category")]
        categoryId,

        /// <remarks/>
        [Display(Name = "Country")]
        country,

        /// <remarks/>
        [Display(Name = "Country of origin")]
        country_of_origin,

        /// <remarks/>
        [Display(Name = "Currency ID")]
        currencyId,

        /// <remarks/>
        [Display(Name = "Tour data")]
        dataTour,

        /// <remarks/>
        [Display(Name = "Date")]
        date,

        /// <remarks/>
        [Display(Name = "Days")]
        days,

        /// <remarks/>
        [Display(Name = "Delivery")]
        delivery,

        /// <remarks/>
        [Display(Name = "Description")]
        description,

        /// <remarks/>
        [Display(Name = "Director")]
        director,

        /// <remarks/>
        [Display(Name = "Downloadeble")]
        downloadable,

        /// <remarks/>
        [Display(Name = "Format")]
        format,

        /// <remarks/>
        [Display(Name = "Hall")]
        hall,

        /// <remarks/>
        [Display(Name = "Hall part")]
        hall_part,

        /// <remarks/>
        [Display(Name = "Hotel rating")]
        hotel_stars,

        /// <remarks/>
        [Display(Name = "Included")]
        included,

        /// <remarks/>
        [Display(Name = "Is kids")]
        is_kids,

        /// <remarks/>
        [Display(Name = "Is premiere")]
        is_premiere,

        /// <remarks/>
        [Display(Name = "Language")]
        language,

        /// <remarks/>
        [Display(Name = "Lacal delivery cost")]
        local_delivery_cost,

        /// <remarks/>
        [Display(Name = "Manufacturer warranty")]
        manufacturer_warranty,

        /// <remarks/>
        [Display(Name = "Meal")]
        meal,

        /// <remarks/>
        [Display(Name = "Media")]
        media,

        /// <remarks/>
        [Display(Name = "Model")]
        model,

        /// <remarks/>
        [Display(Name = "Name")]
        name,

        /// <remarks/>
        [Display(Name = "Original name")]
        originalName,

        /// <remarks/>
        [Display(Name = "Page extent")]
        page_extent,

        /// <remarks/>
        [Display(Name = "Part")]
        part,

        /// <remarks/>
        [Display(Name = "Perfomance type")]
        performance_type,

        /// <remarks/>
        [Display(Name = "Performed by")]
        performed_by,

        /// <remarks/>
        [Display(Name = "Picture")]
        picture,

        /// <remarks/>
        [Display(Name = "Place")]
        place,

        /// <remarks/>
        [Display(Name = "Price")]
        price,

        /// <remarks/>
        [Display(Name = "Publisher")]
        publisher,

        /// <remarks/>
        [Display(Name = "Recording lenght")]
        recording_length,

        /// <remarks/>
        [Display(Name = "Region")]
        region,

        /// <remarks/>
        [Display(Name = "Room")]
        room,

        /// <remarks/>
        [Display(Name = "Series")]
        series,

        /// <remarks/>
        [Display(Name = "Starring")]
        starring,

        /// <remarks/>
        [Display(Name = "Storage")]
        storage,

        /// <remarks/>
        [Display(Name = "Title")]
        title,

        /// <remarks/>
        [Display(Name = "Transport")]
        transport,

        /// <remarks/>
        [Display(Name = "Type prefix")]
        typePrefix,

        /// <remarks/>
        [Display(Name = "Shop")]
        url,

        /// <remarks/>
        [Display(Name = "Vendor")]
        vendor,

        /// <remarks/>
        [Display(Name = "Vendor code")]
        vendorCode,

        /// <remarks/>
        [Display(Name = "Volume")]
        volume,

        /// <remarks/>
        [Display(Name = "World Region")]
        worldRegion,

        /// <remarks/>
        [Display(Name = "Year")]
        year,
    }



}


/*
 *  [System.Xml.Serialization.XmlElementAttribute("ISBN", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("artist", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("author", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("binding", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("categoryId", typeof(yml_catalogShopOfferCategoryId))]
        [System.Xml.Serialization.XmlElementAttribute("country", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("country_of_origin", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("currencyId", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("dataTour", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("date", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("days", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("delivery", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("director", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("downloadable", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("format", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("hall", typeof(yml_catalogShopOfferHall))]
        [System.Xml.Serialization.XmlElementAttribute("hall_part", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("hotel_stars", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("included", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("is_kids", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("is_premiere", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("language", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("local_delivery_cost", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("manufacturer_warranty", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("meal", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("media", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("model", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("originalName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("page_extent", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("part", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("performance_type", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("performed_by", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("picture", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("place", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("price", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("publisher", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("recording_length", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("region", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("room", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("series", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("starring", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("storage", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("transport", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("typePrefix", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("url", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vendor", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vendorCode", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("volume", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("worldRegion", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("year", typeof(ushort))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
 */