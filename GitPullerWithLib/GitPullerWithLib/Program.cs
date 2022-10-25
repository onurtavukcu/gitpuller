using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using System;
using System.Net;

namespace GitPullerWithLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var repo = new Repository(@"C:\XYZ WORK\CrowdFundingAPI"))
                {
                    PullOptions options = new PullOptions();
                    options.FetchOptions = new FetchOptions();

                    options.FetchOptions.CredentialsProvider = new CredentialsHandler(
                        (url, usernameFromUrl, Types) =>
                        new UsernamePasswordCredentials()
                        {
                            Username = "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",
                            Password = String.Empty
                        });

                    var signature = new Signature(
                        new Identity("onurtavukcu", "onur.tavukcu@xyzteknoloji.com"), DateTimeOffset.Now);

                    Commands.Pull(repo, signature, options);
                    Console.WriteLine(repo);
                    Console.WriteLine(options);
                    Console.WriteLine(args);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


//new UsernamePasswordCredentials()
//{
//    Username = "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", // PAT
//    Password = String.Empty
//});







//internal static CredentialsHandler GetCredentialsHandler(NetworkCredential gitCredentials)
//{
//    CredentialsHandler credHandler = (url, fromUrl, types) =>
//    {
//        if ((types & SupportedCredentialTypes.UsernamePassword) == SupportedCredentialTypes.UsernamePassword)
//        {
//            UsernamePasswordCredentials usernamePasswordCredentials = new UsernamePasswordCredentials();
//            if (string.IsNullOrEmpty(gitCredentials.Domain) && string.IsNullOrEmpty(gitCredentials.UserName))
//            {
//                usernamePasswordCredentials.Username = gitCredentials.Password;
//            }
//            else
//            {
//                if (string.IsNullOrEmpty(gitCredentials.Domain))
//                {
//                    usernamePasswordCredentials.Username = gitCredentials.UserName;
//                }
//                else
//                {
//                    usernamePasswordCredentials.Username = string.Format("{0}\\{1}", gitCredentials.Domain,
//                        gitCredentials.UserName);
//                }
//            }

//            usernamePasswordCredentials.Password = gitCredentials.Password;

//            return usernamePasswordCredentials;
//        }

//        return new DefaultCredentials();
//    };

//    return credHandler;
//}
//    NetworkCredential networkCredential = new NetworkCredential("onur.tavukcu@xyzteknoloji.com", "onur1123581321");

//    //using (var repo = new Repository(@"C:\XYZ WORK\CrowdFundingAPI"))
//    //{
//    //    PullOptions options = new PullOptions();
//    //    options.FetchOptions = new FetchOptions();
//    //    options.FetchOptions.CredentialsProvider = GetCredentialsHandler(networkCredential);

//    //    var signature = new Signature(
//    //        new Identity("onurtavukcu", "onur.tavukcu@xyzteknoloji.com"), DateTimeOffset.Now);

//    //    Commands.Pull(repo, signature, options);

//    //};
//}