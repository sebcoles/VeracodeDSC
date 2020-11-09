﻿using Microsoft.Extensions.Configuration;
using Veracode.OSS.Declare.Shared;
using Veracode.OSS.Wrapper;
            IConfiguration Configuration = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
#if DEBUG
                .AddJsonFile($"appsettings.Development.json", false)
#else
                .AddJsonFile("appsettings.json", false)
#endif
                .Build();
            var profileName = Configuration.GetValue<string>("VeracodeProfileName");
            var options = Options.Create(
                VeracodeFileHelper.GetConfiguration(
                    Configuration.GetValue<string>("VeracodeFileLocation"), profileName));

                var retrievedPolicy = _veracodeRepository.GetPolicies().Where(x => x.name == app.application_name).SingleOrDefault();

                foreach (var user in app.users)
                _dscLogic.MakeItSoPolicy(app, app.policy);
            {
                _dscLogic.MakeItSoScan(app, app.files.ToArray(), app.modules.ToArray());
                _dscLogic.MakeItSoMitigations(app);
            }
            TearDownFromConfiguration();

            _veracodeRepository.DeleteApp(new ApplicationType

            _veracodeRepository.DeletePolicy(retrievedPolicy.guid);