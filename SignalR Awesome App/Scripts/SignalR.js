(function () {
    $.connection.hub.start()
        .done(function () {
            console.log("Success")
            $.connection.myHub.server.announce("Connected!");
        })
        .fail(function () { alert("Fail") });

    $.connection.myHub.client.announce = function (message) {

        $("#welcome-messages").append(message + "<br />");
    }
})()