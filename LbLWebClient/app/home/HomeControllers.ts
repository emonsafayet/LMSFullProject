module App {

    class HomeController {
        values:string[];
        static $inject = ["StudentService"];
        constructor(studenService : StudentService) {
            let self = this;
            console.log("I am in Home Controller");
            this.now = new Date().toString();
                }
        now: string;
    }

    //register
    angular.module('app').controller('HomeController', HomeController as any);

}