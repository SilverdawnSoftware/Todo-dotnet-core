define(["angularAMD", "require", "exports", "./AngularJS/Modules/Admin/ModuleAdmin", 'angular-route', 'angular-animate', 'angular-ui-bootstrap', 'angular-sanitize'], function (angularAMD,require, exports, ModuleAdmin_1) { 
         var app = angular.module("webapp", ['ngRoute','ui.bootstrap']);
         app = ModuleAdmin_1.CompareAdminInit(angular);
        return angularAMD.bootstrap(app);
});
//# sourceMappingURL=App.js.map