<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Help.aspx.cs" Inherits="IONS.Help" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMaster" runat="server">
    <h1 class="textAlignCenter" style="color: #45638B">
        Help/Support</h1>
    <table style="width: 100%; text-align: center">
        <tr>
            <td>
                <asp:HyperLink ID="linkDocumentation" CssClass="textAlignCenter" ForeColor="#45638B"
                    runat="server">Click for IONS Documentation</asp:HyperLink>
            </td>
        </tr>
    </table>
    <h2 style="color: #45638B; text-align: center">
        Products</h2>
    <telerik:RadFormDecorator ID="RadFormDecorator1" Skin="Office2010Blue" runat="server"
        DecoratedControls="Scrollbars" />
    <div id="productTable">
        <table style="width: 100%; text-align: center; color: #45638B; border-collapse: collapse">
            <tr>
                <th class="helpTable">
                    Product ID
                </th>
                <th class="helpTable">
                    Name
                </th>
                <th class="helpTable">
                    Description
                </th>
                <th class="helpTable">
                    More Info
                </th>
                <th class="helpTable">
                    Price
                </th>
            </tr>
            <tr>
                <td class="helpTable">
                    BRLD1
                </td>
                <td class="helpTable">
                    Bear Powerful Thousand
                </td>
                <td class="helpTable">
                    1000 Minutes for $10. Nickel for overages.
                </td>
                <td class="helpTable" />
                <td class="helpTable">
                    $10.00
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    BRPH1
                </td>
                <td class="helpTable">
                    Bear Package
                </td>
                <td class="helpTable">
                    This package is for the users that want a little more control of their telephony
                    experience. Anonymous call rejection helps to deter unwanted solicitations from
                    unpublished numbers.
                </td>
                <td class="helpTable">
                    CID, CW, 3-Way, ACR, RD, CF, VM
                </td>
                <td class="helpTable">
                    $39.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    BRTV1
                </td>
                <td class="helpTable">
                    Bear Bonus Package
                </td>
                <td class="helpTable">
                    This is a package for those fond of viewing variety. This package will definitely
                    have something for everyone in the family and several things that all can enjoy
                    together.
                </td>
                <td class="helpTable">
                    299 Channels including 11 premium channels.
                </td>
                <td class="helpTable">
                    $89.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    CBL40MB
                </td>
                <td class="helpTable">
                    40.0MB Bear Cable
                </td>
                <td class="helpTable">
                    High speed internet access through "cable" or coaxial lines. This is almost twice
                    as fast as the Elephant Cable option and is good for homes with a wide array of
                    internet enabled devices. Comes with free home networking.
                </td>
                <td class="helpTable">
                    40mpbs/5mbps
                </td>
                <td class="helpTable">
                    $89.95
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    CHTH100MB
                </td>
                <td class="helpTable">
                    100.0MB Cheetah FiOs
                </td>
                <td class="helpTable">
                    While this solution is not one that everyone will partake of, those that do will
                    not be able to use anything else. This connection would be able to run any of your
                    household operations without a hitch. We even have a 6 month guarantee. If you are
                    not satisfied with the speed of our Cheetah FiOs, we will give you a full refund
                    of all 6 months.
                </td>
                <td class="helpTable">
                    100mpbs/10mpbs
                </td>
                <td class="helpTable">
                    $149.95
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    CHTLD1
                </td>
                <td class="helpTable">
                    Cheetah Unlimited
                </td>
                <td class="helpTable">
                    Unlimited Calls
                </td>
                <td class="helpTable" />
                <td class="helpTable">
                    $20.00
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    CHTPH1
                </td>
                <td class="helpTable">
                    Cheetah Bundle
                </td>
                <td class="helpTable">
                    This is the most comprehensive package with all available phone features. Find me
                    -Follow me makes its appearance for the users that want to be able to be reached
                    no matter what. You can have the phone ring simultaneously at several different
                    numbers.
                </td>
                <td class="helpTable">
                    CID, CW, 3-WAY, ACR, RD, RC, CF, VM, FM-FM
                </td>
                <td class="helpTable">
                    $44.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    CHTTV1
                </td>
                <td class="helpTable">
                    Cheetah Ultimate 500
                </td>
                <td class="helpTable">
                    This package is definitely for TV connoisseurs to enjoy. You must have a love for
                    many programs to be able to handle all that this has to offer. It boasts a proud
                    500 channels of viewing joy that will have you satisfied no matter your taste in
                    programming.
                </td>
                <td class="helpTable">
                    500 Channels including 21 premium channels.
                </td>
                <td class="helpTable">
                    $109.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    ELE25MB
                </td>
                <td class="helpTable">
                    25.0MB Elephant Cable
                </td>
                <td class="helpTable">
                    High speed internet access through "cable" or coaxial lines. Offers higher speeds
                    than all DSL options but the connetion is shared through the neighborhood and is
                    subject to fluxuation.
                </td>
                <td class="helpTable">
                    25mbps/2mpbs
                </td>
                <td class="helpTable">
                    $69.95
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    ELELD1
                </td>
                <td class="helpTable">
                    Elephant Mindful 200
                </td>
                <td class="helpTable">
                    200 Minutes for $7. 10 cents a minute for overages
                </td>
                <td class="helpTable" />
                <td class="helpTable">
                    $7.00
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    ELEPH1
                </td>
                <td class="helpTable">
                    Elephant Package
                </td>
                <td class="helpTable">
                    This package is the most popular package. It comes with the 5 most used features
                    in telephone history. You now have voicemail included to receive messsages.
                </td>
                <td class="helpTable">
                    CID, CW, 3-Way, CF, VM
                </td>
                <td class="helpTable">
                    $29.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    ELETV1
                </td>
                <td class="helpTable">
                    Elephant Standard Package
                </td>
                <td class="helpTable">
                    This is by far the most popular package. Contains most of the popular viewing channels,
                    specialty channels, and 3 premium channels. Best value!
                </td>
                <td class="helpTable">
                    135 Channels including 3 Premium Channels
                </td>
                <td class="helpTable">
                    $69.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    FRG3MB
                </td>
                <td class="helpTable">
                    3.0MB Frog DSL
                </td>
                <td class="helpTable">
                    High Speed Internet access over a dedicated phone line. Does not tie up line while
                    surfing the internet. Has higher speeds and less connection drops than dialup.
                </td>
                <td class="helpTable">
                    3.0mbps/768kbps
                </td>
                <td class="helpTable">
                    $19.95
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    OSCH75MB
                </td>
                <td class="helpTable">
                    75.0MB Ostrich FiOs
                </td>
                <td class="helpTable">
                    High speed internet access through fiber optic lines. Far more powerful than the
                    DSL and Cable options. Each fiber line is ran directly to the premise so there is
                    no connection fluctuation. This service is well suited for home based businesses
                    to run their operations as well as home based servers.
                </td>
                <td class="helpTable">
                    75mpbs/7.5mpbs
                </td>
                <td class="helpTable">
                    $109.95
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    SNLDU
                </td>
                <td class="helpTable">
                    56K Snail Dial-up
                </td>
                <td class="helpTable">
                    Dial-up internet access using land-line. Most economic option for light internet
                    users.
                </td>
                <td class="helpTable">
                    56kpbs/28kbps
                </td>
                <td class="helpTable">
                    $9.95
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    SNLLD1
                </td>
                <td class="helpTable">
                    Snail Steady 30
                </td>
                <td class="helpTable">
                    30 Minutes for $1. 30 cents a minute for overages.
                </td>
                <td class="helpTable" />
                <td class="helpTable">
                    $1.00
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    SNLPH1
                </td>
                <td class="helpTable">
                    Snail Basic Line
                </td>
                <td class="helpTable">
                    Basic telephone line with no features. Gives you a clear connection to the world.
                    Most economic option for light users.
                </td>
                <td class="helpTable">
                    None
                </td>
                <td class="helpTable">
                    $10.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    SNLTV1
                </td>
                <td class="helpTable">
                    Snail Economy Package
                </td>
                <td class="helpTable">
                    The basic package of channels to satisfy basic television needs. Most economic option
                    for the light user.
                </td>
                <td class="helpTable">
                    35 Channels, 0 Premium Channels
                </td>
                <td class="helpTable">
                    $19.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    SQRL10MB
                </td>
                <td class="helpTable">
                    10.0MB Squirrel DSL
                </td>
                <td class="helpTable">
                    High speed internet access over a dedicated phone line. Over 3 times faster than
                    Frog DSL. Can be used for multiple devices around the home.
                </td>
                <td class="helpTable">
                    10mpbs/1.5mbps
                </td>
                <td class="helpTable">
                    $39.95
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    SQRLD1
                </td>
                <td class="helpTable">
                    Squirrel Quick 60
                </td>
                <td class="helpTable">
                    60 Minutes for $4. 15 cents a minute for overages.
                </td>
                <td class="helpTable" />
                <td class="helpTable">
                    $4.00
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    SQRLPH1
                </td>
                <td class="helpTable">
                    Squirrel Package
                </td>
                <td class="helpTable">
                    A convenient little package with the two most desired features. Caller ID and Call
                    Waiting.
                </td>
                <td class="helpTable">
                    CID, CW
                </td>
                <td class="helpTable">
                    $22.99
                </td>
            </tr>
            <tr>
                <td class="helpTable">
                    SQRLTV1
                </td>
                <td class="helpTable">
                    Squirrel Value Package
                </td>
                <td class="helpTable">
                    This is the more in depth programming package that has more family friendly viewing
                    and options for specialty viewers.
                </td>
                <td class="helpTable">
                    70 Channels, 0 Premium Channels
                </td>
                <td class="helpTable">
                    $39.99
                </td>
            </tr>
        </table>
    </div>
</asp:Content>