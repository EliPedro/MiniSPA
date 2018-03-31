var app = angular.module("app", ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Registro/Cursos', { templateUrl: '/app/templates/cursosTemplate.html', controller: 'CursosController' });
        $routeProvider.when('/Registro/Estudantes', { templateUrl: '/app/templates/estudantesTemplate.html', controller: 'EstudantesController' });
        $locationProvider.html5Mode(true);
    });