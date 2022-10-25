//try
//{
//    using (var repo = new Repository(@"C:\XYZ WORK\CrowdFundingAPI"))
//    {
//        PullOptions options = new PullOptions();
//        options.FetchOptions = new FetchOptions();
//        options.FetchOptions.CredentialsProvider = new CredentialsHandler(
//            (url, usernameFromUrl, Types) =>
//            new UsernamePasswordCredentials()
//            {
//                Username = "onur.tavukcu@xyzteknoloji.com",
//                Password = "onur1123581321",
//            });

//        var signature = new Signature(
//            new Identity("onurtavukcu", "onur.tavukcu@xyzteknoloji.com"), DateTimeOffset.Now);

//        Commands.Pull(repo, signature, options);
//        Console.WriteLine(repo);
//        Console.WriteLine(options);
//        Console.WriteLine(args);
//    }
//}
//catch (Exception)
//{
//    throw;
//}