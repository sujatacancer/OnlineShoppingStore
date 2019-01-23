echo %APPLICATION_NAME%
echo %DEPLOYMENT_GROUP_NAME%
aws s3 cp s3://ec3-code/%APPLICATION_NAME%/%DEPLOYMENT_GROUP_NAME%/ c:\SiteData\www.livewatchsecurity.com\ --recursive