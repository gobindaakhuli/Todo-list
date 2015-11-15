using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Entities;
using Todo.Repositories;
using Todo.Repositories.Interfaces;
using Todo.WebUI.Models;

namespace Todo.WebUI.Controllers
{
    public class TaskController : Controller
    {
        //
        // GET: /Todo/

        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Tasks = _taskRepository.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string newTask)
        {
            _taskRepository.Add(newTask);
            ViewBag.Tasks = _taskRepository.GetAll();

            return View();
        }

        [HttpPost]
        public ActionResult Delete(int taskId)
        {
            _taskRepository.Delete(taskId);
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //_taskRepository.Delete(taskId);
            List<TaskEntity> te = _taskRepository.GetAll();
            TaskModel tm = new TaskModel();
            tm.Id = te[id].Id;
            tm.Title = te[id].Title;
            return View(tm);
        }

        [HttpPost]
        public ActionResult Done(int taskId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeStatus(int taskId, bool isDone)
        {
            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult TasksPartial(string taskStatus)
        {
            //todo: реалізувати функцію List<TaskEntity> GetByStatus(bool? status); в репозиторії
            List<TaskEntity> teIn = _taskRepository.GetAll().Where(r => r.IsDone == true).ToList();
            //List<TaskEntity> teOut = new List<TaskEntity>();
            //foreach (TaskEntity te in teIn)
            //{
            //    if (te.IsDone)
            //    {
            //        teOut.Add(te);
            //    }
            //}
            //ViewBag.Tasks = teOut;
            return PartialView("TasksPartial", teIn);
        }

    }
}
