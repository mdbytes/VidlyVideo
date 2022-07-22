$(document).ready(function () {

    console.log("Site JavaScript loaded...");

    function displayAdmin() {

        var admin = $('#user-email').html();

        if (admin === "admin@vidly.com") {
            $('.admin-functions').css("display", "block");
            $('.new-movie').css("display", "block");
            $('.customer-admin-functions').css("display", "table-cell");
            $('#customer-list-table>thead>tr>th.customer-admin-functions').css("display", "table-cell");
            $('#customer-list>tr>td.customer-admin-functions').css("display", "table-cell");
            console.log("is admin");
        } else {
            $('.admin-functions').css("display", "none");
            $('.new-movie').css("display", "none");
            $('#customer-list-table>thead>tr>th.customer-admin-functions').css("display", "none");
            $('#customer-list>tr>td.customer-admin-functions').css("display", "none");
            console.log("not admin");
        }

        var userIdentity = "";

        userIdentity = $('a[Title|="Manage"]').html();

        var adminIdentity = "Hello admin@vidly.com!";
        var employeeIdentity = "Hello employee@vidly.com!";
        var customerIdentity = "Hello customer@vidly.com!";

        console.log("user is  " + userIdentity);

        if (userIdentity === adminIdentity || userIdentity === employeeIdentity) {
            $('#customers-nav').css("display", "block");
            $('#movies-nav').css("display", "block");
            $('#home-login').css("display", "none");
            $('#home-register').css("display", "none");
            $('#home-browse').css("display", "block");
        } else if (userIdentity !== undefined) {
            $('#customers-nav').css("display","none");
            $('#movies-nav').css("display","block");
            $('#home-login').css("display", "none");
            $('#home-register').css("display", "none");
            $('#home-browse').css("display", "block");
        } else {
            $('#customers-nav').css("display", "none");
            $('#movies-nav').css("display", "none");
            $('#home-login').css("display", "block");
            $('#home-register').css("display", "block");
            $('#home-browse').css("display", "none");
        }
    }

    displayAdmin();

});