DynamicsNAVProvider
===================

A Microsoft Dynamics NAV type provider, supporting LINQ queries, schema exploration, individuals and much more besides.

## Building

run build.cmd

<a href="http://forki.github.io/DynamicsNAVProvider" target="_blank">Documentation is available here.</a>

## Known issues

- You are only able to use the SQL provider to access one database in your project. This is because the data context has some static state to enable the communication between the provided types and the runtime. A future release should remove this constraint. 

## Disclaimer

This is an alpha build and as such may have problems yet undetected. This is not suitable for production use.  I am not responsible for any inadvertent damage and destruction caused by this software. 

Always fully assert the results of your queries!


