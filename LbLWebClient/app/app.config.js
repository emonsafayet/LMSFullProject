var App;
(function (App) {
    var app = angular.module('app', ["ui.router"]);
    var Configuration = (function () {
        function Configuration(stateProvider, urlRouterProvider) {
            urlRouterProvider.otherwise("/");
            stateProvider.state("root", {
                abstract: true,
                url: "",
                template: "<div ui-view class=\"container-fluid slide\"></div>",
            })
                .state("root.home", {
                url: "/",
                templateUrl: "partials/home/home.tpl.html",
                controller: "HomeController",
                controllerAs: "vm"
            })
                .state("root.student-entry", {
                url: "/student-entry",
                templateUrl: "partials/student/student-entry.tpl.html",
                controller: "StudentController",
                controllerAs: "vm"
            })
                .state("root.student-list", {
                url: "/student-list",
                templateUrl: "partials/student/student-list.tpl.html",
                controller: "StudentsController",
                controllerAs: "vm"
            });
        }
        return Configuration;
    }());
    Configuration.$inject = ["$stateProvider", "$urlRouterProvider"];
    // register class which and How
    angular.module('app').config(Configuration);
})(App || (App = {}));
//# sourceMappingURL=app.config.js.map