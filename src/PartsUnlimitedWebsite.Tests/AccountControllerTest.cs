using PartsUnlimited.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartsUnlimited.Controllers;

namespace PartsUnlimited.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for AccountController</summary>
    [TestClass]
    [PexClass(typeof(AccountController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AccountControllerTest
    {

        /// <summary>Test stub for ConfirmEmail(String, String)</summary>
        [PexMethod]
        public Task<ActionResult> ConfirmEmailTest(
            [PexAssumeUnderTest]AccountController target,
            string userId,
            string code
        )
        {
            Task<ActionResult> result = target.ConfirmEmail(userId, code);
            return result;
            // TODO: add assertions to method AccountControllerTest.ConfirmEmailTest(AccountController, String, String)
        }

        /// <summary>Test stub for ExternalLogin(String, String)</summary>
        [PexMethod]
        public ActionResult ExternalLoginTest(
            [PexAssumeUnderTest]AccountController target,
            string provider,
            string returnUrl
        )
        {
            ActionResult result = target.ExternalLogin(provider, returnUrl);
            return result;
            // TODO: add assertions to method AccountControllerTest.ExternalLoginTest(AccountController, String, String)
        }

        /// <summary>Test stub for ExternalLoginCallback(String)</summary>
        [PexMethod]
        public Task<ActionResult> ExternalLoginCallbackTest([PexAssumeUnderTest]AccountController target, string returnUrl)
        {
            Task<ActionResult> result = target.ExternalLoginCallback(returnUrl);
            return result;
            // TODO: add assertions to method AccountControllerTest.ExternalLoginCallbackTest(AccountController, String)
        }

        /// <summary>Test stub for ExternalLoginConfirmation(ExternalLoginConfirmationViewModel, String)</summary>
        [PexMethod]
        public Task<ActionResult> ExternalLoginConfirmationTest(
            [PexAssumeUnderTest]AccountController target,
            ExternalLoginConfirmationViewModel model,
            string returnUrl
        )
        {
            Task<ActionResult> result = target.ExternalLoginConfirmation(model, returnUrl);
            return result;
            // TODO: add assertions to method AccountControllerTest.ExternalLoginConfirmationTest(AccountController, ExternalLoginConfirmationViewModel, String)
        }

        /// <summary>Test stub for ExternalLoginFailure()</summary>
        [PexMethod]
        public ActionResult ExternalLoginFailureTest([PexAssumeUnderTest]AccountController target)
        {
            ActionResult result = target.ExternalLoginFailure();
            return result;
            // TODO: add assertions to method AccountControllerTest.ExternalLoginFailureTest(AccountController)
        }

        /// <summary>Test stub for ForgotPassword()</summary>
        [PexMethod]
        public ActionResult ForgotPasswordTest([PexAssumeUnderTest]AccountController target)
        {
            ActionResult result = target.ForgotPassword();
            return result;
            // TODO: add assertions to method AccountControllerTest.ForgotPasswordTest(AccountController)
        }

        /// <summary>Test stub for ForgotPassword(ForgotPasswordViewModel)</summary>
        [PexMethod]
        public Task<ActionResult> ForgotPasswordTest01([PexAssumeUnderTest]AccountController target, ForgotPasswordViewModel model)
        {
            Task<ActionResult> result = target.ForgotPassword(model);
            return result;
            // TODO: add assertions to method AccountControllerTest.ForgotPasswordTest01(AccountController, ForgotPasswordViewModel)
        }

        /// <summary>Test stub for ForgotPasswordConfirmation()</summary>
        [PexMethod]
        public ActionResult ForgotPasswordConfirmationTest([PexAssumeUnderTest]AccountController target)
        {
            ActionResult result = target.ForgotPasswordConfirmation();
            return result;
            // TODO: add assertions to method AccountControllerTest.ForgotPasswordConfirmationTest(AccountController)
        }

        /// <summary>Test stub for LogOff()</summary>
        [PexMethod]
        public ActionResult LogOffTest([PexAssumeUnderTest]AccountController target)
        {
            ActionResult result = target.LogOff();
            return result;
            // TODO: add assertions to method AccountControllerTest.LogOffTest(AccountController)
        }

        /// <summary>Test stub for Login(String)</summary>
        [PexMethod]
        public ActionResult LoginTest([PexAssumeUnderTest]AccountController target, string returnUrl)
        {
            ActionResult result = target.Login(returnUrl);
            return result;
            // TODO: add assertions to method AccountControllerTest.LoginTest(AccountController, String)
        }

        /// <summary>Test stub for Login(LoginViewModel, String)</summary>
        [PexMethod]
        public Task<ActionResult> LoginTest01(
            [PexAssumeUnderTest]AccountController target,
            LoginViewModel model,
            string returnUrl
        )
        {
            Task<ActionResult> result = target.Login(model, returnUrl);
            return result;
            // TODO: add assertions to method AccountControllerTest.LoginTest01(AccountController, LoginViewModel, String)
        }

        /// <summary>Test stub for Register()</summary>
        [PexMethod]
        public ActionResult RegisterTest([PexAssumeUnderTest]AccountController target)
        {
            ActionResult result = target.Register();
            return result;
            // TODO: add assertions to method AccountControllerTest.RegisterTest(AccountController)
        }

        /// <summary>Test stub for Register(RegisterViewModel)</summary>
        [PexMethod]
        public Task<ActionResult> RegisterTest01([PexAssumeUnderTest]AccountController target, RegisterViewModel model)
        {
            Task<ActionResult> result = target.Register(model);
            return result;
            // TODO: add assertions to method AccountControllerTest.RegisterTest01(AccountController, RegisterViewModel)
        }

        /// <summary>Test stub for ResetPassword(String)</summary>
        [PexMethod]
        public ActionResult ResetPasswordTest([PexAssumeUnderTest]AccountController target, string code)
        {
            ActionResult result = target.ResetPassword(code);
            return result;
            // TODO: add assertions to method AccountControllerTest.ResetPasswordTest(AccountController, String)
        }

        /// <summary>Test stub for ResetPassword(ResetPasswordViewModel)</summary>
        [PexMethod]
        public Task<ActionResult> ResetPasswordTest01([PexAssumeUnderTest]AccountController target, ResetPasswordViewModel model)
        {
            Task<ActionResult> result = target.ResetPassword(model);
            return result;
            // TODO: add assertions to method AccountControllerTest.ResetPasswordTest01(AccountController, ResetPasswordViewModel)
        }

        /// <summary>Test stub for ResetPasswordConfirmation()</summary>
        [PexMethod]
        public ActionResult ResetPasswordConfirmationTest([PexAssumeUnderTest]AccountController target)
        {
            ActionResult result = target.ResetPasswordConfirmation();
            return result;
            // TODO: add assertions to method AccountControllerTest.ResetPasswordConfirmationTest(AccountController)
        }

        /// <summary>Test stub for SendCode(String, Boolean)</summary>
        [PexMethod]
        public Task<ActionResult> SendCodeTest(
            [PexAssumeUnderTest]AccountController target,
            string returnUrl,
            bool rememberMe
        )
        {
            Task<ActionResult> result = target.SendCode(returnUrl, rememberMe);
            return result;
            // TODO: add assertions to method AccountControllerTest.SendCodeTest(AccountController, String, Boolean)
        }

        /// <summary>Test stub for SendCode(SendCodeViewModel)</summary>
        [PexMethod]
        public Task<ActionResult> SendCodeTest01([PexAssumeUnderTest]AccountController target, SendCodeViewModel model)
        {
            Task<ActionResult> result = target.SendCode(model);
            return result;
            // TODO: add assertions to method AccountControllerTest.SendCodeTest01(AccountController, SendCodeViewModel)
        }

        /// <summary>Test stub for VerifyCode(String, String, Boolean)</summary>
        [PexMethod]
        public Task<ActionResult> VerifyCodeTest(
            [PexAssumeUnderTest]AccountController target,
            string provider,
            string returnUrl,
            bool rememberMe
        )
        {
            Task<ActionResult> result = target.VerifyCode(provider, returnUrl, rememberMe);
            return result;
            // TODO: add assertions to method AccountControllerTest.VerifyCodeTest(AccountController, String, String, Boolean)
        }

        /// <summary>Test stub for VerifyCode(VerifyCodeViewModel)</summary>
        [PexMethod]
        public Task<ActionResult> VerifyCodeTest01([PexAssumeUnderTest]AccountController target, VerifyCodeViewModel model)
        {
            Task<ActionResult> result = target.VerifyCode(model);
            return result;
            // TODO: add assertions to method AccountControllerTest.VerifyCodeTest01(AccountController, VerifyCodeViewModel)
        }
    }
}
