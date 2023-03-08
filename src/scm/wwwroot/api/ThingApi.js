var ThingApi = {
    Create: function (thing) {
        return fetch("api/things", {
            method: "post",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(thing),
        });
    },

    Get: function (processThings) {
        return fetch("api/things")
            .then((response) => response.json())
            .then((things) => processThings(things));
    },

    Delete: function (thing) {
        return fetch("api/things", {
            method: "delete",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(thing),
        });
    },
};
