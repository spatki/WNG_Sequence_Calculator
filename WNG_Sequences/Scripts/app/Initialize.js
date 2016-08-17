try {
    var app = angular.module("App", []);
    app.controller('SequenceControl', function ($scope, $http, $timeout, $q) {
        $scope.Sequences = {};  // Initialize
        $scope.InputNumber = { InputNumber : "", CustomValidation : false, CustomValidationMessage : "" };
        $("#processing").hide();

        $scope.GetSequences = function () {
            var canceler = $q.defer;
            var processed = false;
            // Call Server Action
            $scope.Sequences = {};
            $("#processing").show();
            $http({
                method: 'POST',
                url: '/Home/GenerateSequences',
                data: $scope.InputNumber,
                timeout: canceler.promise
            }).success(function (data) {
                $scope.InputNumber.CustomValidation = false;
                $scope.InputNumber.CustomValidationMessage = "";
                $scope.Sequences = data;
                processed = true;
                $("#processing").hide();
            }).error(function (data) {
                $scope.InputNumber = data;
                $scope.Sequences = {};
                processed = true;
                $("#processing").hide();
            });
            $timeout(function () {
                if (!processed) {
                    canceler.resolve();
                    $scope.InputNumber.CustomValidation = true;
                    $scope.InputNumber.CustomValidationMessage = "Processing for too long. Pl. enter another number";
                    processed = true;
                    $("#processing").hide();
                }
            }, 6000);
        }
    });
} catch (err) { alert("Error in AngularJS: " + err.message); }
