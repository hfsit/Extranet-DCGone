<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HFSExtranet_CafeToGo.ascx.cs"
    Inherits="CMSWebParts_HFSExtranet_HFSExtranet_CafeToGo" %>

<script>
    var test;
    var cafeToGoInventory = {
        "categories": {
            "coffeeAndTea": {
                "categoryName": "Coffee and Tea",
                "items": [
                    {
                        "itemImage": "/HFSExtranet/media/Eat/Cafe%20To%20Go/Coffee.png",
                        "itemName": "Coffee",
                        "itemOptions": [
                            {
                                "optionName": "Traveler",
                                "optionPrice": 16.95
                            },
                            {
                                "optionName": "Shuttle",
                                "optionPrice": 26.95
                            },
                            {
                                "optionName": "Cambro",
                                "optionPrice": 49.95
                            }
                        ],
                        "itemDescription": "<p>Freshly brewed Starbucks<sup>&reg;</sup> coffee.</p>"
                    },
                    {
                        "itemImage": "/HFSExtranet/media/Eat/Cafe%20To%20Go/Coffee.png",
                        "itemName": "Decaf Coffee",
                        "itemOptions": [
                            {
                                "optionName": "Traveler",
                                "optionPrice": 16.95
                            },
                            {
                                "optionName": "Shuttle",
                                "optionPrice": 26.95
                            },
                            {
                                "optionName": "Cambro",
                                "optionPrice": 49.95
                            }
                        ],
                        "itemDescription": "<p>Freshly brewed decaf Starbucks<sup>&reg;</sup> coffee.</p>"
                    }
                ]
            }
        }
    };

    $(function () {
        

        $(cafeToGoInventory.categories["coffeeAndTea"].items).each(function (index, value) {
            var thisItem = value;
            var thisItemTemplate = $('#cafeToGoItemTemplate').clone().removeAttr('id');
            var cardText = thisItemTemplate.find($('.card-text'));
            cardText.html('<p>BLAH</p>');



            thisItemTemplate.appendTo('#coffeeAndTeaItems');
        });


        /*

        var cart;

        $('#cafeToGo_coffee_add').click(function () {
            var itemName = $(this).attr('id').split('_')[1];
            var itemOption = $('#cafeToGo_' + itemName + '_option').val();
            var itemQty = $('#cafeToGo_' + itemName + '_qty').val();

            alert('Adding item: ' + itemName + '.\n\nSelected type: ' + itemOption + '\n\nQty: ' + itemQty);
            if (itemOption == null || itemQty == null || !itemQty.match(/^[1-9][0-9]?$/)) alert('Please select a valid option and quantity.');
            else {
                
            }
            return false;
        });
        */
    });
</script>

<div class="d-none">
    <div id="cafeToGoItemTemplate" class="col-12 col-md-6 col-lg-3">
        <div class="card">
            <img class="card-img-top" src="/HFSExtranet/media/Eat/Cafe%20To%20Go/Coffee.png"
                alt="Coffee">
            <div class="card-body">
                <h5 class="card-title">Coffee</h5>
                <div class="card-text">
                    <!-- itemDescription -->
                </div>

            </div>
            <div class="card-footer pt-0 pb-4 border-top-0 bg-transparent">
                <div class="form-group">
                    <select id="cafeToGo_coffee_option" class="form-control form-control-sm">
                        <option selected="selected" disabled="disabled">SELECT SIZE</option>
                        <option value="16.95">Traveler $16.95</option>
                        <option value="26.95">Shuttle $26.95</option>
                        <option value="49.95">Cambro $49.95</option>
                    </select>
                </div>
                <div class="form-group d-flex justify-content-between">
                    <button id="cafeToGo_coffee_add" class="btn btn-primary btn-sm d-block mr-3" style="-webkit-box-flex: 1;
                        -ms-flex-positive: 1; flex-grow: 1">
                        ADD TO CART</button>
                    <input id="cafeToGo_coffee_qty" class="form-control form-control-sm" type="number"
                        min="0" max="99" style="width: 3.5rem;" />
                </div>
            </div>
        </div>
    </div>
</div>

<div class="container">
    <div class="row justify-content-center">
        <div class="col-12 col-lg-9 text-center">
            <h2>Coffee and Tea</h2>
            <p>
                <b>Traveler</b> 10 cups, <b>Shuttle</b> 16 cups, <b>Cambro</b> 40 cups<br />
                Your order includes cups, sugar, 0-calorie sweeteners, half-n-half, stir sticks,
                and napkins
            </p>
        </div>
    </div>
    <div id="coffeeAndTeaItems" class="row">
        <!-- Items get dynamically created here -->
    </div>
</div>
