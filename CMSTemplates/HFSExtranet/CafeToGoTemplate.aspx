<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/HFSExtranet/KenticoMaster.master" AutoEventWireup="true" CodeFile="CafeToGoTemplate.aspx.cs" Inherits="CMSTemplates_HFSExtranet_CafeToGoTemplate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MasterHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MasterBody" Runat="Server">
    <cms:CMSPagePlaceholder ID="plcZones" runat="server">
        <LayoutTemplate>
            <cms:CMSWebPartZone ID="zoneMain" runat="server" />
        </LayoutTemplate>
    </cms:CMSPagePlaceholder>
    <asp:UpdatePanel runat="server">

        <ContentTemplate>
            <asp:Panel ID="pnlCafeToGoMain" runat="server">
                <div class="container">
                    <div class="row justify-content-center mb-3">
                        <div class="col-12 col-lg-9 text-center">
                            <h2>Coffee and Tea</h2>
                            <p>
                                <b>Traveler</b> 10 cups<br />
                                Your order includes cups, sugar, 0-calorie sweeteners, half-and-half, stir sticks
                                and napkins
                            </p>
                        </div>
                    </div>
                    <div class="row mt-3 justify-content-center">
                        <asp:Repeater ID="rptCoffeeAndTea" runat="server" OnItemDataBound="rptCafeToGoItems_ItemDataBound"
                            OnItemCommand="rptCafeToGoItems_ItemCommand">
                            <ItemTemplate>
                                <asp:HiddenField ID="ItemName" runat="server" Value='<%# Eval("Name") %>' />
                                <div class="col-12 col-sm-6 col-md-4 col-lg-3 my-2">
                                    <div class="card cafetogo-card">
                                        <img class="card-img-top" src='<%# Eval("ImageUrl") %>'
                                            alt='<%# Eval("Name") %>'>
                                        <div class="card-body">
                                            <h5 class="card-title"><%# Eval("Name") %></h5>
                                            <div class="card-text">
                                                <%# Eval("DescriptionHtml") %>
                                            </div>
                                        </div>
                                        <div class="card-footer bg-transparent border-top-0 pt-0 pb-4">
                                            <div class="form-group">
                                                <asp:DropDownList ID="ddlOptions" runat="server" CssClass="form-control form-control-sm" />
                                            </div>
                                            <div class="form-group d-flex">
                                                <asp:Button runat="server" CommandName="AddToCart" CausesValidation="false" Text="ADD TO CART"
                                                    CssClass="btn btn-primary btn-sm mr-3 cafetogo-button-addtocart" />
                                                <asp:TextBox ID="txtQty" runat="server" CssClass="form-control form-control-sm col-3" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="row justify-content-center mb-3">
                        <div class="col-12 col-lg-9 text-center">
                            <h2>Bakery Baskets</h2>
                            <p>Each bakery basket is filled with an assortment of a dozen pastries.  Please  ask about compostable tableware.</p>
                        </div>
                    </div>
                    <div class="row mt-3 justify-content-center">
                        <asp:Repeater ID="rptBakeryBaskets" runat="server" OnItemDataBound="rptCafeToGoItems_ItemDataBound"
                            OnItemCommand="rptCafeToGoItems_ItemCommand">
                            <ItemTemplate>
                                <asp:HiddenField ID="ItemName" runat="server" Value='<%# Eval("Name") %>' />
                                <div class="col-12 col-sm-6 col-md-4 col-lg-3 my-2">
                                    <div class="card cafetogo-card">
                                        <img class="card-img-top" src='<%# Eval("ImageUrl") %>'
                                            alt='<%# Eval("Name") %>'>
                                        <div class="card-body">
                                            <h5 class="card-title"><%# Eval("Name") %></h5>
                                            <div class="card-text">
                                                <%# Eval("DescriptionHtml") %>
                                            </div>
                                        </div>
                                        <div class="card-footer bg-transparent border-top-0 pt-0 pb-4">
                                            <div class="form-group">
                                                <asp:DropDownList ID="ddlOptions" runat="server" CssClass="form-control form-control-sm" />
                                            </div>
                                            <div class="form-group d-flex">
                                                <asp:Button runat="server" CommandName="AddToCart" CausesValidation="false" Text="ADD TO CART"
                                                    CssClass="btn btn-primary btn-sm mr-3 cafetogo-button-addtocart" />
                                                <asp:TextBox ID="txtQty" runat="server" CssClass="form-control form-control-sm col-3" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="row justify-content-center mb-3">
                        <div class="col-12 col-lg-9 text-center">
                            <h2>Bottled Beverages</h2>
                            <p>A variety of bottled beverages for your convenience.</p>
                        </div>
                    </div>
                    <div class="row mt-3 justify-content-center">
                        <asp:Repeater ID="rptBottledBeverages" runat="server" OnItemDataBound="rptCafeToGoItems_ItemDataBound"
                            OnItemCommand="rptCafeToGoItems_ItemCommand">
                            <ItemTemplate>
                                <asp:HiddenField ID="ItemName" runat="server" Value='<%# Eval("Name") %>' />
                                <div class="col-12 col-sm-6 col-md-4 col-lg-3 my-2">
                                    <div class="card cafetogo-card">
                                        <img class="card-img-top" src='<%# Eval("ImageUrl") %>'
                                            alt='<%# Eval("Name") %>'>
                                        <div class="card-body">
                                            <h5 class="card-title"><%# Eval("Name") %></h5>
                                            <div class="card-text">
                                                <%# Eval("DescriptionHtml") %>
                                            </div>
                                        </div>
                                        <div class="card-footer bg-transparent border-top-0 pt-0 pb-4">
                                            <div class="form-group">
                                                <asp:DropDownList ID="ddlOptions" runat="server" CssClass="form-control form-control-sm" />
                                            </div>
                                            <div class="form-group d-flex">
                                                <asp:Button runat="server" CommandName="AddToCart" CausesValidation="false" Text="ADD TO CART"
                                                    CssClass="btn btn-primary btn-sm mr-3 cafetogo-button-addtocart" />
                                                <asp:TextBox ID="txtQty" runat="server" CssClass="form-control form-control-sm col-3" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="row justify-content-center mb-3">
                        <div class="col-12 col-lg-9 text-center">
                            <h2>Snacks</h2>
                            <p>Tasty bites for events, ready to grab and enjoy.</p>
                        </div>
                    </div>
                    <div class="row mt-3 justify-content-center">
                        <asp:Repeater ID="rptSnacks" runat="server" OnItemDataBound="rptCafeToGoItems_ItemDataBound"
                            OnItemCommand="rptCafeToGoItems_ItemCommand">
                            <ItemTemplate>
                                <asp:HiddenField ID="ItemName" runat="server" Value='<%# Eval("Name") %>' />
                                <div class="col-12 col-sm-6 col-md-4 col-lg-3 my-2">
                                    <div class="card cafetogo-card">
                                        <img class="card-img-top" src='<%# Eval("ImageUrl") %>'
                                            alt='<%# Eval("Name") %>'>
                                        <div class="card-body">
                                            <h5 class="card-title"><%# Eval("Name") %></h5>
                                            <div class="card-text">
                                                <%# Eval("DescriptionHtml") %>
                                            </div>
                                        </div>
                                        <div class="card-footer bg-transparent border-top-0 pt-0 pb-4">
                                            <div class="form-group">
                                                <asp:DropDownList ID="ddlOptions" runat="server" CssClass="form-control form-control-sm" />
                                            </div>
                                            <div class="form-group d-flex">
                                                <asp:Button runat="server" CommandName="AddToCart" CausesValidation="false" Text="ADD TO CART"
                                                    CssClass="btn btn-primary btn-sm mr-3 cafetogo-button-addtocart" />
                                                <asp:TextBox ID="txtQty" runat="server" CssClass="form-control form-control-sm col-3" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
                <div class="background-purple">
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-12 col-lg-9">
                                <h4 style="text-align: center;">Sandwich and salad orders must be placed 2 weeks in advance to ensure product availability.</h4>
                                <p style="text-align: center;">If you would like to place a sandwich/salad order with less than two weeks notice, please email <a href="mailto:cafetogo@uw.edu">cafetogo@uw.edu</a> to discuss options and availability. Maximum order is 15 servings.</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="container">
                    <div class="row justify-content-center mb-3">
                        <div class="col-12 col-lg-9 text-center">
                            <h2>Sandwich &amp; Salad Lunches</h2>
                            <p>Each meal includes one entr&eacute;e, a bag of Lays chips, and a 20oz. bottle of Aquafina water.</p>
                            <p>* Orders must be placed 2 weeks in advance to ensure product availability</p>
                            <p>* Maximum order is 15 servings</p>
                            <p>Choices for Entr&eacute;e's include:</P>
                        </div>
                    </div>
                    <div class="row mt-3 justify-content-center">
                        <asp:Repeater ID="rptSandwichSaladLunches" runat="server" OnItemDataBound="rptCafeToGoItems_ItemDataBound"
                            OnItemCommand="rptCafeToGoItems_ItemCommand">
                            <ItemTemplate>
                                <asp:HiddenField ID="ItemName" runat="server" Value='<%# Eval("Name") %>' />
                                <div class="col-12 col-sm-6 col-md-4 col-lg-3 my-2">
                                    <div class="card cafetogo-card">
                                        <img class="card-img-top" src='<%# Eval("ImageUrl") %>'
                                            alt='<%# Eval("Name") %>'>
                                        <div class="card-body">
                                            <h5 class="card-title"><%# Eval("Name") %></h5>
                                            <div class="card-text">
                                                <%# Eval("DescriptionHtml") %>
                                            </div>
                                        </div>
                                        <div class="card-footer bg-transparent border-top-0 pt-0 pb-4">
                                            <div class="form-group">
                                                <asp:DropDownList ID="ddlOptions" runat="server" CssClass="form-control form-control-sm" />
                                            </div>
                                            <div class="form-group d-flex">
                                                <asp:Button runat="server" CommandName="AddToCart" CausesValidation="false" Text="ADD TO CART"
                                                    CssClass="btn btn-primary btn-sm mr-3 cafetogo-button-addtocart" />
                                                <asp:TextBox ID="txtQty" runat="server" CssClass="form-control form-control-sm col-3" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="row justify-content-center">
                        <div class="col-12 col-lg-9 text-center">
                            <h2>Order Information and Summary</h2>
                            <p>Review your order then click the Place Your Order button.</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12 col-md-6">
                            <div class="border px-3 py-2 mb-3">
                                <p><b>PLATES, NAPKINS & UTENSILS&mdash;ORDER BY THE BUNDLE</b></p>
                                <p>Each place setting includes a plate, napkin and utensils. Each bundle contains 15 place settings.</p>
                                <div class="form-group form-inline row mb-2">
                                    <div class="col-sm-6 col-12">
                                        <asp:Button runat="server" CausesValidation="false" Text="ADD TO CART" OnClick="btnCafeToGoAddUtensils_Click"
                                        CssClass="btn btn-primary btn-sm cafetogo-button-addtocart w-100" />
                                    </div>
                                    <div class="col-sm-6 col-12">
                                        <asp:DropDownList runat="server" ID="ddlUtensils" CssClass="form-control form-control-sm w-100">
                                            <asp:ListItem Value="0" disabled="disabled" selected="selected">QTY OF BUNDLES</asp:ListItem>
                                            <asp:ListItem Value="1">1 (15 place settings): $10.99</asp:ListItem>
                                            <asp:ListItem Value="2">2 (30 place settings): $21.98</asp:ListItem>
                                            <asp:ListItem Value="3">3 (45 place settings): $32.97</asp:ListItem>
                                            <asp:ListItem Value="4">4 (60 place settings): $43.96</asp:ListItem>
                                            <asp:ListItem Value="5">5 (75 place settings): $54.95</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="border px-3 py-2 mb-3">
                                <p><b>PICKUP LOCATION</b></p>
                                <div class="form-group form-inline">
                                    <asp:DropDownList ID="ddlLocations" runat="server" CssClass="form-control form-control-sm" DataTextField="Location" DataValueField="Location" OnDataBound="ddlLocations_DataBound" />
                                    <asp:RequiredFieldValidator runat="server"
                                        InitialValue="0" 
                                        ControlToValidate="ddlLocations"
                                        ErrorMessage="Please select a valid location."
                                        CssClass="invalid-feedback"
                                        Display="Dynamic" />
                                </div>
                            </div>
                            <div class="border px-3 py-2 mb-3">
                                <p><b>DATE AND TIME TO PICK UP YOUR ORDER</b></p>
                                <div class="form-group form-inline">
                                    <asp:TextBox ID="txtDate" runat="server" TextMode="Date" CssClass="form-control w-50" />
                                    <asp:TextBox ID="txtTime" runat="server" TextMode="Time" CssClass="form-control w-50" />
                                    <asp:RequiredFieldValidator runat="server"
                                        Display="Dynamic"
                                        CssClass="invalid-feedback"
                                        ControlToValidate="txtDate"
                                        ErrorMessage="Please enter a valid date." />
                                    <asp:RequiredFieldValidator runat="server"
                                        Display="Dynamic"
                                        CssClass="invalid-feedback"
                                        ControlToValidate="txtTime"
                                        ErrorMessage="Please enter a valid time." />
                                    <asp:Panel ID="pnlPickUpTimeInvalid" runat="server" Visible="false">
                                        <p>
                                            <span class="invalid-feedback" style="display:inline">Pickup date/time must be at least one hour in the future.</span>
                                        </p>
                                    </asp:Panel>
                                </div>
                            </div>
                            <div class="border px-3 py-2 mb-3">
                                <p><b>CONTACT INFORMATION</b></p>
                                <div class="form-group">
                                    <asp:Label runat="server"
                                        AssociatedControlID="txtContactInfoName"
                                        Text="* Name" />
                                    <asp:TextBox ID="txtContactInfoName" runat="server"
                                        CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server"
                                        ControlToValidate="txtContactInfoName"
                                        CssClass="invalid-feedback"
                                        Display="Dynamic"
                                        Text="Name is a required field." />
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server"
                                        AssociatedControlID="txtContactInfoDepartment"
                                        Text="* Department" />
                                    <asp:TextBox ID="txtContactInfoDepartment" runat="server"
                                        CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server"
                                        ControlToValidate="txtContactInfoDepartment"
                                        CssClass="invalid-feedback"
                                        Display="Dynamic"
                                        Text="Department is a required field." />
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server"
                                        AssociatedControlID="txtContactInfoPhone"
                                        Text="Phone" />
                                    <asp:TextBox ID="txtContactInfoPhone" runat="server"
                                        CssClass="form-control"
                                        TextMode="Phone" />
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server"
                                        AssociatedControlID="txtContactInfoEmployeeIDNumber"
                                        Text="Employee ID Number (For UW Internal funding purchases only)" />
                                    <asp:TextBox ID="txtContactInfoEmployeeIDNumber" runat="server"
                                        CssClass="form-control" />
                                    <asp:RegularExpressionValidator runat="server"
                                        CssClass="invalid-feedback"
                                        ControlToValidate="txtContactInfoEmployeeIDNumber"
                                        Display="Dynamic"
                                        ErrorMessage="Employee number must be exactly 9 digits."
                                        ValidationExpression="^\d{9}$" />
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server"
                                        AssociatedControlID="txtContactInfoEmail"
                                        Text="* Email" />
                                    <asp:TextBox ID="txtContactInfoEmail" runat="server"
                                        CssClass="form-control"
                                        TextMode="Email" />
                                    <asp:RequiredFieldValidator runat="server"
                                        ControlToValidate="txtContactInfoEmail"
                                        CssClass="invalid-feedback"
                                        Display="Dynamic"
                                        Text="Email is a required field." />
                                </div>
                                
                                
                                <p>
                                    We do not offer delivery at this time. Our caf&eacute; representative will confirm your
                                    pickup date and time after we receive your order.  Please note that some locations may/may not have requested items.
                                </p>
                                <p><b>CANCELLATION POLICY</b></p>
                                <p>
                                    Please allow two business days prior to your scheduled pick-up for cancellations.
                                </p>
                            </div>
                        </div>
                        <div class="col-12 col-md-6">
                            <div class="border px-3 py-2 mb-3">
                                <p><b>ORDER SUMMARY</b></p>
                                <asp:GridView ID="grdCafeToGoCart" runat="server" AutoGenerateColumns="false" CssClass="table table-sm"
                                    GridLines="None"
                                    OnDataBinding="grdCafeToGoCart_DataBinding">
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <div class="form-group text-center">
                                                    <asp:LinkButton ID="btnCafeToGoCartRemoveItem" runat="server" OnClick="btnCafeToGoCartRemoveItem_Click"
                                                        CssClass="form-control-plaintext" CausesValidation="false"><i class="fa fa-trash-o" aria-hidden="true"></i></asp:LinkButton>
                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="QTY">
                                            <ItemTemplate>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtCafeToGoCartItemQty" OnTextChanged="txtCafeToGoCartItemQty_TextChanged"
                                                        TextMode="Number" runat="server" Text='<%# Eval("Quantity") %>' size="2" AutoPostBack="true"
                                                        CssClass="form-control w-100" CausesValidation="false" />
                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Item">
                                            <ItemTemplate>
                                                <div class="form-group">
                                                    <div class="form-control-plaintext">
                                                        <%# Eval("ItemName") %>: <%# Eval("ItemOption").ToString().Split('(')[0].Trim() %>
                                                    </div>
                                                </div>

                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="/EA" HeaderStyle-CssClass="text-right">
                                            <ItemTemplate>
                                                <div class="form-group">
                                                    <div class="text-right form-control-plaintext">$<%# Eval("Price") %></div>
                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <EmptyDataTemplate>
                                        <div class="text-center text-muted"><i>(No items in cart)</i></div>
                                    </EmptyDataTemplate>
                                </asp:GridView>
                                <asp:Panel ID="pnlTotalNoTax" runat="server" Visible="false">
                                    <table class="table table-sm">
                                        <tbody>
                                            <tr>
                                                <td><b>TOTAL</b></td>
                                                <td class="text-right"><b>
                                                    <asp:Label ID="lblCafeToGoCartTotal" runat="server"></asp:Label></b></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </asp:Panel>
                                <asp:Panel ID="pnlTotalWithTax" runat="server" Visible="true">
                                    <table class="table table-sm">
                                        <tbody>
                                            <tr>
                                                <td>Estimated Tax:</td>
                                                <td class="text-right">
                                                    <asp:Label ID="lblCafeToGoCartTax" runat="server"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td><b>TOTAL</b></td>
                                                <td class="text-right"><b>
                                                    <asp:Label ID="lblCafeToGoCartTotalWithTax" runat="server"></asp:Label></b></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </asp:Panel>
                                <asp:Panel ID="pnlCartEmptyError" runat="server" Visible="false">
                                    <p><span class="invalid-feedback" style="display:inline">Please add one or more items to your cart to submit your order.</span></p>
                                </asp:Panel>

                            </div>
                            <div class="border px-3 py-2">
                                <p><b>PAYMENT METHOD</b></p>
                                <p>
                                    Payment is due at time of pickup. If you are using UW internal funding, please enter desired costing information below.
                                </p>
                                <p>
                                    <asp:RadioButtonList ID="rblPaymentMethod" runat="server"
                                        RepeatDirection="Vertical"
                                        RepeatLayout="Flow"
                                        AutoPostBack="True"
                                        OnSelectedIndexChanged="rblPaymentMethod_SelectedIndexChanged">
                                        <asp:ListItem Text="Credit Card" />
                                        <asp:ListItem Text="Husky Card" />
                                        <asp:ListItem Text="UW internal funding" />
                                    </asp:RadioButtonList>
                                </p>
                                <asp:Panel ID="pnlUWBudgetInfo" runat="server" Visible="false">
                                    <!--
                                        <p>
                                            <strong>UW BUDGET ACCOUNT INFORMATION</strong>
                                        </p>
                                        <p>
                                            <em>For orders placed by June 29 for pick up no later than June 30</em>
                                        </p>
                                        <div class="form-group">
                                            <asp:Label runat="server"
                                                AssociatedControlID="txtBudgetNumber"
                                                Text="Budget Number"></asp:Label>
                                            <asp:TextBox ID="txtBudgetNumber" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label runat="server"
                                                AssociatedControlID="txtTaskOptionProject"
                                                Text="Task, Option & Project" />
                                            <asp:TextBox ID="txtTaskOptionProject" runat="server"
                                                CssClass="form-control" />
                                        </div>
                                    -->
                                    <div class="form-group">
                                        <asp:Label runat="server"
                                            AssociatedControlID="txtWorktag"
                                            Text="Cost Center, Program, Project, Gift, or Grant" />
                                        <asp:TextBox ID="txtWorktag" runat="server"
                                            CssClass="form-control" />
                                        <asp:RegularExpressionValidator runat="server"
                                            CssClass="invalid-feedback"
                                            ControlToValidate="txtWorktag"
                                            Display="Dynamic"
                                            ErrorMessage="Driver worktag must be exactly 2 letters followed by 6 digits. Example: CC123456"
                                            ValidationExpression="^[A-Za-z]{2}\d{6}$" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server"
                                            AssociatedControlID="txtResource"
                                            Text="Resource (required if using a Cost Center value)" />
                                        <asp:TextBox ID="txtResource" runat="server"
                                            CssClass="form-control" />
                                        <asp:RegularExpressionValidator runat="server"
                                            CssClass="invalid-feedback"
                                            ControlToValidate="txtResource"
                                            Display="Dynamic"
                                            ErrorMessage="Resource must be 'RS' followed by 6 digits."
                                            ValidationExpression="^RS\d{6}$" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server"
                                            AssociatedControlID="txtCompany"
                                            Text="Company" />
                                        <asp:TextBox ID="txtCompany" runat="server"
                                            CssClass="form-control" />
                                        <asp:RegularExpressionValidator runat="server"
                                            CssClass="invalid-feedback"
                                            ControlToValidate="txtCompany"
                                            Display="Dynamic"
                                            ErrorMessage="Company must be 6 or fewer alphanumeric characters."
                                            ValidationExpression="^[0-9A-Za-z]{0,6}$" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server"
                                            AssociatedControlID="txtBudgetCoordinator"
                                            Text="Budget Coordinator" />
                                        <asp:TextBox ID="txtBudgetCoordinator" runat="server"
                                            CssClass="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server"
                                            AssociatedControlID="txtMailboxNumber"
                                            Text="Campus Mailbox Number" />
                                        <asp:TextBox ID="txtMailboxNumber" runat="server"
                                            CssClass="form-control" />
                                    </div>
                                </asp:Panel>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12 text-center">
                            <asp:Button ID="btnCafeToGoPlaceOrder" runat="server" OnClick="btnCafeToGoPlaceOrder_Click"
                                CssClass="btn btn-primary" Text="PLACE YOUR ORDER" />
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="pnlCafeToGoSuccess" runat="server"
                Visible="false">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-12 col-lg-9">
                            <div class="alert alert-success">
                                <p>Your order has been successfully submitted.</p>
                                <p><a class="alert-link" href="/Eat">Click here</a> to return to the Eat home page.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="pnlCafeToGoFailure" runat="server"
                Visible="false">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-12 col-lg-9">
                            <div class="alert alert-danger">
                                <p>An error occurred.</p>
                                <p><a class="alert-link" href="#" onclick="window.history.go(-1);return false;">Click
                                    here</a> to go back.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </ContentTemplate>


    </asp:UpdatePanel>

</asp:Content>

