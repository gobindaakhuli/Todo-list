(function () {

    var onIsDoneClick = function (e) {

        console.log("[tasks-page] - checkbox click", e.target);

        var ch = e.target;
        var isDone = ch.checked;

        console.log("[tasks-page] - checkbox click: isDone = " + isDone);
        //console.log("[tasks-page] - checkbox click: isDone = " + ch.dataset.taskId);

        var taskId = ch.getAttribute("data-task-id");
        var isChecked = ch.checked;
        console.log("[tasks-page] - checkbox click: id = " + taskId);

        $.ajax({
            url: "/Task/ChangeStatus",
            type: "POST",
            dataType: "text",
            data: {
                taskId: taskId,
                isDone: isDone
            }
        }).done(function () {
            console.log("ChangeStatus - All right");
        }).fail(function () {
            console.log("ChangeStatus - All left");
        });
    };

    var onTaskStatusFilterChanged = function (e) {
        console.log("[tasks-page] onTaskStatusFilterChanged", e.target.value);

        var status = e.target.value;

        $.ajax({
            url: "/Task/TasksPartial",
            type: "POST",
            dataType: "html",
            data: {
                taskStatus: status
            }
        }).done(function (data) {
            $("#tasks-table").html(data);
            //todo: привязати обробник події на checkbox
            console.log("ChangeStatusFilter - All right");
        }).fail(function () {
            console.log("ChangeStatusFilter - All left");
        });
    };

    var init = function () {
        console.log("[tasks-page] - init");
        $("input[type='checkbox']").on("click", onIsDoneClick);
        $("#task-status-filter").on("change", onTaskStatusFilterChanged);
    };

    $(function () {
        console.log("[tasks-page] - test");
        init();
    });


})();