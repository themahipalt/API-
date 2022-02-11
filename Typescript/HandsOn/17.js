//enum demo2
var AppStatus;
(function (AppStatus) {
    AppStatus["ACTIVE"] = "ACT";
    AppStatus["INACTIVE"] = "INACT";
    AppStatus[AppStatus["ONSTOP"] = 0] = "ONSTOP";
    AppStatus[AppStatus["ONHOLD"] = 1] = "ONHOLD";
})(AppStatus || (AppStatus = {}));
console.log(AppStatus.ONHOLD);
console.log(AppStatus.ONSTOP);
