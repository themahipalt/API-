//enum 
var Week;
(function (Week) {
    Week[Week["Mon"] = 10] = "Mon";
    Week[Week["Tue"] = 11] = "Tue";
    Week[Week["Wed"] = 12] = "Wed";
    Week[Week["Thu"] = 13] = "Thu";
    Week[Week["Fri"] = 20] = "Fri";
    Week[Week["Sat"] = 21] = "Sat";
    Week[Week["Sun"] = 22] = "Sun";
})(Week || (Week = {}));
console.log(Week.Fri);
