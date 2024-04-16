using CMS.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class CMSTemplates_HFSExtranet_CafeToGoTemplate : TemplatePage
{
    public static decimal TaxRate = 0.101M;

    List<CafeToGo_CartItem> CafeToGo_CartItems
    {
        get
        {
            return (List<CafeToGo_CartItem>)Session["CafeToGo_CartItems"];
        }
        set
        {
            Session["CafeToGo_CartItems"] = value;
        }
    }



    List<CafeToGo_Item> CafeToGo_Inventory = new List<CafeToGo_Item>
    {
        /**
         * Coffee and Tea
         * */

        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.CoffeeAndTea,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Coffee.png",
            Name = "Coffee",
            DescriptionHtml = "<p>Freshly brewed Starbucks<sup>&reg;</sup> coffee.</p>",
            OptionsPlaceholderText = "SELECT SIZE",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Traveler",
                    Price = 21.25M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.CoffeeAndTea,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Coffee-decaf.png",
            Name = "Decaf Coffee",
            DescriptionHtml = "<p>Freshly brewed decaf Starbucks<sup>&reg;</sup> coffee.</p>",
            OptionsPlaceholderText = "SELECT SIZE",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Traveler",
                    Price = 21.25M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.CoffeeAndTea,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Tazo-tea.png",
            Name = "Teavana<sup>&reg;</sup> Tea",
            DescriptionHtml = "<p>Assortment of Teavana teas with hot water.</p>",
            OptionsPlaceholderText = "SELECT SIZE",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Traveler",
                    Price = 21.25M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.CoffeeAndTea,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Hot-water.jpg",
            Name = "Hot Water",
            DescriptionHtml = "<p>10 cups of piping hot water.</p>",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Traveler",
                    Price = 9.25M
                }
            }
        },

        /**
         * Bakery Baskets
         * */

        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BakeryBaskets,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Muffins.png",
            Name = "Muffins",
            DescriptionHtml = "<p>A variety of our delicious, fluffy muffins in assorted flavors.</p>",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Dozen",
                    Price = 27.05M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BakeryBaskets,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Scones.png",
            Name = "Scones",
            DescriptionHtml = "<p>An assortment of our crumbly, lightly sweetened scones.</p>",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Dozen",
                    Price = 25.99M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BakeryBaskets,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Donuts.png",
            Name = "Donuts",
            DescriptionHtml = "<p>An array of our light, airy decadent donuts.</p>",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption{
                    Text = "Dozen",
                    Price = 24.95M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BakeryBaskets,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Bagels.png",
            Name = "Bagels",
            DescriptionHtml = "<p>Fresh, soft, and chewy assortment of bagels.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                
                new CafeToGo_ItemOption
                {
                    Text = "Dozen with Cream Cheese",
                    Price = 28.09M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Dozen w/o Cream Cheese",
                    Price = 21.85M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BakeryBaskets,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Cinnamon-roll-2.jpg",
            Name = "Cinnamon Rolls",
            DescriptionHtml = "<p>Light and tender on the inside.</p>",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Dozen",
                    Price = 35.35M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BakeryBaskets,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Brownies.jpg",
            Name = "Brownies",
            DescriptionHtml = "<p>A variety of our decadent chocolate brownies.</p>",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Dozen",
                    Price = 35.35M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BakeryBaskets,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Cookies.jpg",
            Name = "Cookie Assortment",
            DescriptionHtml = "<p>Fresh-baked, decadent gourmet cookies.</p>",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Dozen",
                    Price = 24.95M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BakeryBaskets,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Croissants.png",
            Name = "Croissants",
            DescriptionHtml = "<p>Classic butter croissants with soft, flaky layers and a golden-brown crust.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Dozen, Plain",
                    Price = 32.99M
                }
            }
        },

        /**
         * Bottled Beverages
         * */

        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BottledBeverages,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Soda.png",
            Name = "Soda",
            DescriptionHtml = "<p>20 ounce cold and sparkling Pepsi products.</p>",
            OptionsPlaceholderText = "SELECT FLAVOR",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Pepsi",
                    Price = 3.34M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Diet pepsi",
                    Price = 2.99M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Mug Root Beer",
                    Price = 3.34M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Dr. Pepper",
                    Price = 3.34M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Starry",
                    Price = 3.34M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BottledBeverages,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/juice.jpg",
            Name = "Juice",
            DescriptionHtml = "<p>Healthy and refreshing, full of flavor, in 20 ounce bottles.</p>",
            OptionsPlaceholderText = "SELECT FLAVOR",
            Options = new List<CafeToGo_ItemOption>
            {                
                new CafeToGo_ItemOption
                {
                    Text = "Dole Juice Apple",
                    Price = 2.99M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Dole Juice Orange",
                    Price = 2.99M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Dole Juice Cranberry",
                    Price = 3.26M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Dole Juice Cran-Grape",
                    Price = 3.26M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BottledBeverages,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Honest-tea.png",
            Name = "Water and Tea",
            DescriptionHtml = "<p>Refreshing Aquafina water and Pure Leaf Tea. Real-brewed tea in a variety of flavors.</p>",
            OptionsPlaceholderText = "SELECT FLAVOR",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Water: 20oz Aquafina",
                    Price = 2.19M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Teas: Pure Leaf Unsweetened",
                    Price = 4.31M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Teas: Pure Leaf Sweetened",
                    Price = 4.31M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Teas: Pure Leaf Green",
                    Price = 4.31M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Teas: Pure Leaf Lemon",
                    Price = 4.31M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.BottledBeverages,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/SBUX%20Frappucino.jpg",
            Name = "Starbucks Frappuccino",
            DescriptionHtml = "<p>Get the boost you need in a convenient portable bottle.</p>",
            OptionsPlaceholderText = "SELECT FLAVOR",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Mocha",
                    Price = 6.13M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Coffee",
                    Price = 6.13M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Caramel",
                    Price = 6.13M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Vanilla",
                    Price = 6.13M
                },
                new CafeToGo_ItemOption
                {
                    Text = "White Choc.",
                    Price = 6.13M
                }
            }
        },

        /**
         * Snacks
         * */

        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.Snacks,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/That%27s%20it%20bar.jpg",
            Name = "Assorted That's It Bars",
            DescriptionHtml = "<p>100% real fruit bars made with no added preservatives, sugar, concentrates, or puree.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "3 Apple Pear & 3 Apple Mango",
                    Price = 13.00M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.Snacks,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/CLIF%20bar.jpg",
            Name = "Assorted Clif Bars",
            DescriptionHtml = "<p>Fight off hunger and get the protein you need with snack bars.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "3 Cool Mint Choc & 3 Nut Butter Choc/PB",
                    Price = 17.00M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.Snacks,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Terra%20Chips.jpg",
            Name = "Terra Chips",
            DescriptionHtml = "<p>A delicious variety of sweet and savory vegetables chips.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Terra Chips",
                    Price = 1.89M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.Snacks,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Pop%20Chips.jpg",
            Name = "Pop Chips",
            DescriptionHtml = "<p>Smokey, tangy BBQ chips.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Popchips BBQ",
                    Price = 1.89M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.Snacks,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Sabra%20Avocado%20Toast.jpg",
            Name = "Sabra Avocado Toast",
            DescriptionHtml = "<p>Blended Hass Avocado spread with whole grain toast for a convenient snack.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Avocado Toast",
                    Price = 4.49M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.Snacks,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Sabra%20Hummus.jpg",
            Name = "Sabra Hummus",
            DescriptionHtml = "<p>Creamy hummus and crunchy pretzels come together for a delicious grab &amp; go snack.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Classic Hummus w/pretzel",
                    Price = 4.49M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.Snacks,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Yogurt.jpg",
            Name = "Elleno's Yogurt",
            DescriptionHtml = "<p>Local, handcrafted Greek yogurt.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "MarionBerry",
                    Price = 5.29M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Mango",
                    Price = 5.29M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Museli",
                    Price = 5.29M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.Snacks,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Sahale%20nuts.jpg",
            Name = "Sahale Nuts",
            DescriptionHtml = "<p>Portable fruit and nut mixture.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Honey Almond",
                    Price = 2.49M
                },
                new CafeToGo_ItemOption
                {
                    Text = "Raspberry Crumble",
                    Price = 2.49M
                }
            }
        },

        /**
         * Sandwich & Salad Lunches
         * */

        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.SandwichSaladLunches,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Turkey%20sandwich.jpg",
            Name = "Turkey Cheddar Sandwich",
            DescriptionHtml = "<p>Smoked turkey, lettuce, tomato, roasted garlic balsamic mayo, and cheddar cheese on sourdough bread.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Turkey Cheddar Sandwich",
                    Price = 13.00M
                }
            }
        },
        // new CafeToGo_Item
        // {
        //     Category = CafeToGo_Categories.SandwichSaladLunches,
        //     ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Focaccia%20sandwhich.jpg",
        //     Name = "Italian Foccacia Sandwich",
        //     DescriptionHtml = "<p>Fire-smoked ham, prosciutto, salami, olive spread, tomato aioli and provolone on rosemary focaccia.</p>",
        //     OptionsPlaceholderText = "SELECT OPTION",
        //     Options = new List<CafeToGo_ItemOption>
        //     {
        //         new CafeToGo_ItemOption
        //         {
        //             Text = "Italian Foccacia Sandwich",
        //             Price = 13.00M
        //         }
        //     }
        // },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.SandwichSaladLunches,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Ceaser%20salad.jpg",
            Name = "Chicken Kale Caesar Salad",
            DescriptionHtml = "<p>Romaine and kale blend, seasoned chicken, Parmesan cheese and homemade croutons served with Caesar dressing.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Chicken Kale Caesar Salad",
                    Price = 13.00M
                }
            }
        },
        new CafeToGo_Item
        {
            Category = CafeToGo_Categories.SandwichSaladLunches,
            ImageUrl = "/HFSExtranet/media/Eat/Cafe%20To%20Go/Farmer%20salad.jpg",
            Name = "Farmers Market Salad",
            DescriptionHtml = "<p>Spinach, kale, chard, fris&eacute;e, cucumber, grape tomatoes and carrots served with balsamic vinaigrette.</p>",
            OptionsPlaceholderText = "SELECT OPTION",
            Options = new List<CafeToGo_ItemOption>
            {
                new CafeToGo_ItemOption
                {
                    Text = "Farmers Market Salad",
                    Price = 13.00M
                }
            }
        },
        
    };

    protected void Page_Load(object sender, EventArgs e)
    {
        Page.MaintainScrollPositionOnPostBack = true;
        if (!IsPostBack)
        {
            rblPaymentMethod.SelectedIndex = 0;
            CafeToGo_CartItems = new List<CafeToGo_CartItem>();

            List<CafeToGo_Location> cafeToGo_Locations = new List<CafeToGo_Location>();

            using (var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HFS_DB"].ConnectionString))
            {
                var sqlCommand = new SqlCommand("SELECT LocationName FROM CafeToGo_Locations WHERE (LocationValidStart IS NULL OR LocationValidStart < GETDATE()) AND (LocationValidEnd IS NULL OR LocationValidEnd > GETDATE()) ORDER BY LocationName", sqlConnection);
                sqlConnection.Open();

                var sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var locationName = (string)sqlDataReader["LocationName"];
                    var location = new CafeToGo_Location { Location = locationName };
                    cafeToGo_Locations.Add(location);
                }
            }

            rptCoffeeAndTea.DataSource = CafeToGo_Inventory.Where(i => i.Category == CafeToGo_Categories.CoffeeAndTea).ToList();
            rptCoffeeAndTea.DataBind();

            rptBakeryBaskets.DataSource = CafeToGo_Inventory.Where(i => i.Category == CafeToGo_Categories.BakeryBaskets).ToList();
            rptBakeryBaskets.DataBind();

            rptBottledBeverages.DataSource = CafeToGo_Inventory.Where(i => i.Category == CafeToGo_Categories.BottledBeverages).ToList();
            rptBottledBeverages.DataBind();

            rptSnacks.DataSource = CafeToGo_Inventory.Where(i => i.Category == CafeToGo_Categories.Snacks).ToList();
            rptSnacks.DataBind();

            rptSandwichSaladLunches.DataSource = CafeToGo_Inventory.Where(i => i.Category == CafeToGo_Categories.SandwichSaladLunches).ToList();
            rptSandwichSaladLunches.DataBind();

            ddlLocations.DataSource = cafeToGo_Locations;
            ddlLocations.DataBind();

            grdCafeToGoCart.DataSource = CafeToGo_CartItems;
            grdCafeToGoCart.DataBind();
        }
    }


    protected void rptCafeToGoItems_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        DropDownList ddlOptions = ((DropDownList)e.Item.FindControl("ddlOptions"));
        ddlOptions.DataSource = ((CafeToGo_Item)e.Item.DataItem).Options;
        ddlOptions.DataTextField = "FullText";
        ddlOptions.DataValueField = "FullText";
        ddlOptions.DataBind();

        if (ddlOptions.Items.Count > 1)
        {
            ddlOptions.Items.Insert(0, new ListItem(((CafeToGo_Item)e.Item.DataItem).OptionsPlaceholderText));
            ddlOptions.Items[0].Attributes.Add("disabled", "disabled");
            ddlOptions.Items[0].Attributes.Add("selected", "selected");
        }

        TextBox txtQty = ((TextBox)e.Item.FindControl("txtQty"));
        txtQty.Attributes.Add("placeholder", "QTY");

    }

    protected void rptCafeToGoItems_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string ItemName = ((HiddenField)e.Item.FindControl("ItemName")).Value; // Because e.Item.DataItem is inaccessible from this context.
        DropDownList ddlOptions = ((DropDownList)e.Item.FindControl("ddlOptions"));
        string ItemOption = ((DropDownList)e.Item.FindControl("ddlOptions")).SelectedItem.Text;
        TextBox txtQty = ((TextBox)e.Item.FindControl("txtQty"));

        uint Quantity;

        if (!uint.TryParse(txtQty.Text, out Quantity)) return;

        if (ddlOptions.SelectedIndex == 0 && ddlOptions.Items.Count > 1) return;

        decimal Price = decimal.Parse(ddlOptions.SelectedValue.ToString().Split('(')[1].Replace("$", "").Replace(")", ""));

        AddItemToCart(
            new CafeToGo_CartItem
            {
                ItemName = ItemName,
                ItemOption = ItemOption,
                Price = Price,
                Quantity = Quantity
            }
        );


    }

    protected void ddlLocations_DataBound(object sender, EventArgs e)
    {
        ddlLocations.Items.Insert(0, new ListItem("SELECT LOCATION", "0"));
        ddlLocations.Items[0].Attributes.Add("disabled", "disabled");
        ddlLocations.Items[0].Attributes.Add("selected", "selected");

    }

    protected void AddItemToCart(CafeToGo_CartItem CartItem)
    {
        CafeToGo_CartItem ExistingItem = CafeToGo_CartItems.Where(i => i.ItemID == CartItem.ItemID).FirstOrDefault();

        if (ExistingItem == null)
        {
            CafeToGo_CartItems.Add(CartItem);
        }
        else
        {
            ExistingItem.Quantity += CartItem.Quantity;
        }
        grdCafeToGoCart.DataBind();

    }

    protected void UpdateItemQtyInCart(CafeToGo_CartItem CartItem)
    {
        if (CartItem.Quantity == 0)
        {
            CafeToGo_CartItems.Remove(CafeToGo_CartItems.Where(i => i.ItemID == CartItem.ItemID).First());
        }
        else
        {
            CafeToGo_CartItems.Where(i => i.ItemID == CartItem.ItemID).First().Quantity = CartItem.Quantity;
        }


        grdCafeToGoCart.DataBind();
    }

    protected void grdCafeToGoCart_DataBinding(object sender, EventArgs e)
    {
        grdCafeToGoCart.DataSource = CafeToGo_CartItems;

        // Update other cart-based things here, like total.

        decimal CartTotal = 0.0M;
        foreach (CafeToGo_CartItem ThisCartItem in CafeToGo_CartItems) CartTotal += (ThisCartItem.Price * ThisCartItem.Quantity);

        lblCafeToGoCartTotal.Text = "$" + CartTotal.ToString("0.00");

        decimal TaxTotal = Decimal.Round(CartTotal * TaxRate, 2);

        lblCafeToGoCartTax.Text = "$" + TaxTotal.ToString("0.00");

        decimal CartTotalWithTax = CartTotal + TaxTotal;

        lblCafeToGoCartTotalWithTax.Text = "$" + CartTotalWithTax.ToString("0.00");

        pnlCartEmptyError.Visible = false;

    }

    protected void txtCafeToGoCartItemQty_TextChanged(object sender, EventArgs e)
    {
        TextBox ThisQuantityTextbox = ((TextBox)sender);
        int ThisItemIndex = ((GridViewRow)ThisQuantityTextbox.NamingContainer).RowIndex;
        uint NewQuantity;
        if (uint.TryParse(ThisQuantityTextbox.Text, out NewQuantity))
        {
            CafeToGo_CartItems[ThisItemIndex].Quantity = NewQuantity;
        }
        else
        {
            ThisQuantityTextbox.Text = CafeToGo_CartItems[ThisItemIndex].Quantity.ToString();
        }
        grdCafeToGoCart.DataBind();

    }

    protected void btnCafeToGoCartRemoveItem_Click(object sender, EventArgs e)
    {
        CafeToGo_CartItems.RemoveAt(((GridViewRow)((LinkButton)sender).NamingContainer).RowIndex);
        grdCafeToGoCart.DataBind();

    }

    protected void btnCafeToGoAddUtensils_Click(object sender, EventArgs e)
    {
        var utensilsQty = uint.Parse(ddlUtensils.SelectedItem.Value);
        
        AddItemToCart(
            new CafeToGo_CartItem
            {
                ItemName = "Utensil Bundles",
                ItemOption = "15pc/ea",
                Price = 10.99M,
                Quantity = utensilsQty
            }
        );

        ddlUtensils.SelectedIndex = 0;
    }

    protected void btnCafeToGoPlaceOrder_Click(object sender, EventArgs e)
    {
        var cartIsEmpty = CafeToGo_CartItems.Count() == 0;
        pnlCartEmptyError.Visible = cartIsEmpty;
        if (cartIsEmpty) return;

        var pickUpTimeInvalid = DateTime.Parse(txtDate.Text + " " + txtTime.Text) < DateTime.Now.AddHours(1);
        pnlPickUpTimeInvalid.Visible = pickUpTimeInvalid;
        if (pickUpTimeInvalid) return;

        if (!Page.IsValid) return;

        HFSEmailUtil.HFSEmail Email = new HFSEmailUtil.HFSEmail();

        Email.From = "cafetogo@uw.edu";
        Email.Subject = "Cafe to Go Order - " + ddlLocations.SelectedValue.ToString();
        Email.IsHtmlBody = true;

        Email.Body += "<h1>Cafe to Go Order</h1>";

        Email.Body += "<table cellspacing=\"0\" border=\"1\" cellpadding=\"5\"><thead><tr><th>Item</th><th>Quantity</th><th>Price</th></tr></thead><tbody>";

        decimal CartSubTotal = 0.0M;

        foreach (CafeToGo_CartItem ThisCartItem in CafeToGo_CartItems)
        {
            Email.Body += "<tr><td>" + ThisCartItem.ItemName + ": " + ThisCartItem.ItemOption + "</td><td>" + ThisCartItem.Quantity.ToString() + "</td><td>$" + (ThisCartItem.Quantity * ThisCartItem.Price).ToString("0.00") + "</td></tr>";
            CartSubTotal += ThisCartItem.Price * ThisCartItem.Quantity;
        }

        if (pnlTotalNoTax.Visible) Email.Body += "<tr><td colspan=\"2\"><b>Total</b></td><td><b>$" + CartSubTotal.ToString("0.00") + "</b></td></tr>";
        else Email.Body += "<tr><td colspan=\"2\">SubTotal</td><td>$" + CartSubTotal.ToString("0.00") + "</td></tr><tr><td colspan=\"2\">Estimated tax</td><td>$" + (CartSubTotal * TaxRate).ToString("0.00") + "</td></tr><tr><td colspan=\"2\"><b>Total</b></td><td><b>$" + (CartSubTotal + CartSubTotal * TaxRate).ToString("0.00") + "</b></td></tr>";
        Email.Body += "</tbody></table>";

        Email.Body += "<h2>Order Information</h2>";

        Email.Body += "<p>Order Submitted: " + DateTime.Now.ToString() + "</p>";
        Email.Body += "<p>Pickup Date/Time: " + DateTime.Parse(txtDate.Text + " " + txtTime.Text).ToString() + "</p>";
        Email.Body += "<p>Payment Method: " + rblPaymentMethod.SelectedItem.Text + "</p>";

        Email.Body += "<h2>Contact Information</h2>";
        Email.Body += "<p>Name: " + txtContactInfoName.Text + "</p>";
        Email.Body += "<p>Department: " + txtContactInfoDepartment.Text + "</p>";
        Email.Body += "<p>Phone: " + txtContactInfoPhone.Text + "</p>";
        Email.Body += "<p>Employee ID Number: " + txtContactInfoEmployeeIDNumber.Text + "</p>";
        Email.Body += "<p>Email: " + txtContactInfoEmail.Text + "</p>";
        Email.Body += "<p>Campus Mailbox Number: " + txtMailboxNumber.Text + "</p>";
        
        Email.Body += "<h3>Budget Information</h3>";
        // Email.Body += "<p>Budget Number: " + txtBudgetNumber.Text + "</p>";
        // Email.Body += "<p>Task, Option & Project: " + txtTaskOptionProject.Text + "</p>";
        Email.Body += "<p>Cost Center, Program, Project, Gift, or Grant: " + txtWorktag.Text + "</p>";
        Email.Body += "<p>Resource: " + txtResource.Text + "</p>";
        Email.Body += "<p>Company: " + txtCompany.Text + "</p>";
        Email.Body += "<p>Budget Coordinator: " + txtBudgetCoordinator.Text + "</p>";

        Email.To = "cafetogo@uw.edu," + txtContactInfoEmail.Text;

        if(!HttpContext.Current.Request.Url.Host.Equals("hfs.uw.edu", StringComparison.OrdinalIgnoreCase))
        {
            Email.To = txtContactInfoEmail.Text;
            Email.Subject = "(TEST) " + Email.Subject;
            Email.Body = "<p><em>This was generated from the TEST Cafe to Go application, please disregard this order.</em></p>" + Email.Body;
        }

        if (Email.sendEmail())
        {
            pnlCafeToGoSuccess.Visible = true;
        }
        else
        {
            pnlCafeToGoFailure.Visible = true;
        }
        pnlCafeToGoMain.Visible = false;
    }

    protected void rblPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Index = ((RadioButtonList)sender).SelectedIndex;

        pnlTotalNoTax.Visible = (Index == 2);
        pnlUWBudgetInfo.Visible = (Index == 2);
        pnlTotalWithTax.Visible = !pnlTotalNoTax.Visible;
    }

    protected void ddlOptions_DataBinding(object sender, EventArgs e)
    {

    }

    protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

/**
 * Accessory Classes
 * */

public class CafeToGo_Item
{
    public CafeToGo_Categories Category { get; set; }
    public string ImageUrl { get; set; }
    public string Name { get; set; }
    public string DescriptionHtml { get; set; }
    public string OptionsPlaceholderText { get; set; }
    public List<CafeToGo_ItemOption> Options { get; set; }
}

public class CafeToGo_ItemOption
{
    public string Text { get; set; }
    public decimal Price { get; set; }
    public string FullText { get { return Text + " ($" + Price.ToString() + ")"; } }
}

public enum CafeToGo_Categories
{
    CoffeeAndTea,
    BakeryBaskets,
    BottledBeverages,
    Snacks,
    SandwichSaladLunches
}

public class CafeToGo_CartItem
{
    public string ItemName { get; set; }
    public string ItemOption { get; set; }
    public string ItemID { get { return ItemName + " - " + ItemOption; } }

    public uint Quantity { get; set; }
    public decimal Price { get; set; }

}

public class CafeToGo_Location
{
    public string Location { get; set; }
}