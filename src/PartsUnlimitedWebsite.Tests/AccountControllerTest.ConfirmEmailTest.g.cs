using System.Collections.Generic;
using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Web.Mvc;
using PartsUnlimited.Controllers;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace PartsUnlimited.Controllers.Tests
{
    public partial class AccountControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest434()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      AccountController accountController;
      Task<ActionResult> task;
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)accountController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)accountController).TempData = (TempDataDictionary)null;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, (string)null, (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.RanToCompletion, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNull(((ControllerBase)accountController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest339()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      AccountController accountController;
      Task<ActionResult> task;
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)accountController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)accountController).TempData = (TempDataDictionary)null;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, "", (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.RanToCompletion, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNull(((ControllerBase)accountController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest237()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      AccountController accountController;
      Task<ActionResult> task;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)accountController).ControllerContext = s0;
      ((ControllerBase)accountController).TempData = (TempDataDictionary)null;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, (string)null, (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.RanToCompletion, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNotNull(((ControllerBase)accountController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)accountController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest56()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      AccountController accountController;
      Task<ActionResult> task;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)accountController).ControllerContext = s0;
      ((ControllerBase)accountController).TempData = (TempDataDictionary)null;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, (string)null, (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.RanToCompletion, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNotNull(((ControllerBase)accountController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)accountController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest922()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      AccountController accountController;
      Task<ActionResult> task;
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)accountController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)accountController).TempData = (TempDataDictionary)null;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, "", "");
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.Faulted, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(true, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNull(((ControllerBase)accountController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest484()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TempDataDictionary tempDataDictionary;
      AccountController accountController;
      Task<ActionResult> task;
      tempDataDictionary = new TempDataDictionary();
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)accountController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)accountController).TempData = tempDataDictionary;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, (string)null, (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.RanToCompletion, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNull(((ControllerBase)accountController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest175()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ViewEngineCollection viewEngineCollection;
      AccountController accountController;
      Task<ActionResult> task;
      IViewEngine[] iViewEngines = new IViewEngine[0];
      viewEngineCollection =
        new ViewEngineCollection((IList<IViewEngine>)iViewEngines);
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection = viewEngineCollection;
      ((ControllerBase)accountController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)accountController).TempData = (TempDataDictionary)null;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, (string)null, (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.RanToCompletion, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNull(((ControllerBase)accountController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest141()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      AccountController accountController;
      Task<ActionResult> task;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = routeData;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)accountController).ControllerContext = s0;
      ((ControllerBase)accountController).TempData = (TempDataDictionary)null;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, (string)null, (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.RanToCompletion, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNotNull(((ControllerBase)accountController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)accountController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AccountControllerTest))]
public void ConfirmEmailTest994()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      AccountController accountController;
      Task<ActionResult> task;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      accountController = new AccountController();
      ((Controller)accountController).Resolver = (IDependencyResolver)null;
      ((Controller)accountController).ActionInvoker = (IActionInvoker)null;
      ((Controller)accountController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)accountController).Url = (UrlHelper)null;
      ((Controller)accountController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)accountController).ControllerContext = s0;
      ((ControllerBase)accountController).TempData = (TempDataDictionary)null;
      ((ControllerBase)accountController).ValidateRequest = false;
      ((ControllerBase)accountController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)accountController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)accountController);
      task = this.ConfirmEmailTest(accountController, (string)null, (string)null);
      disposables.Add((IDisposable)task);
      disposables.Dispose();
      Assert.IsNotNull((object)task);
      Assert.AreEqual<TaskStatus>(TaskStatus.RanToCompletion, ((Task)task).Status);
      Assert.AreEqual<bool>(false, ((Task)task).IsCanceled);
      Assert.IsNull(((Task)task).AsyncState);
      Assert.AreEqual<bool>(false, ((Task)task).IsFaulted);
      Assert.IsNotNull((object)accountController);
      Assert.IsNotNull(((Controller)accountController).AsyncManager);
      Assert.IsNotNull
          (((Controller)accountController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)accountController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)accountController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)accountController).Url);
      Assert.IsNotNull(((ControllerBase)accountController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)accountController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)accountController).ValidateRequest);
    }
}
    }
}
