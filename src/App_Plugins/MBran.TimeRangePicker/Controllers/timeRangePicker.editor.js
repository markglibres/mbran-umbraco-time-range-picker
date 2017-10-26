angular.module('umbraco')
    .controller('MBran.TimeRangePicker',
    function ($scope) {

        if (!$scope.model.value) {
            $scope.model.value = {};

            $scope.model.value.start = {
                hour: '8',
                minute: '00',
                meridian: 'AM'
            };

            $scope.model.value.end = {
                hour: '6',
                minute: '00',
                meridian: 'PM'
            };
        }

        $scope.times = {
            hours: ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12'],
            minutes: ['00', '05', '10', '15', '20', '25', '30', '35', '40', '45', '50', '55'],
            meridian: ['AM', 'PM']
        };

    });