# a learning project

this is a place for learning, 
a sandbox if you will 

[![Current deployment status](https://github.com/patstha/waling/actions/workflows/Waling20230316072851.yml/badge.svg)](https://github.com/patstha/waling/actions/workflows/Waling20230316072851.yml)

New project: 

Add a simple poll 

![North Star](./assets/woot-northstar.png)

```bash
[kushal@2603-8080-f403-b15a-0000-0000-0000-185e ~]$ time sudo echo "hello"; date; time flatpak update -y; date; time sudo dnf offline-upgrade download -y && time sudo dnf offline-upgrade reboot
[sudo] password for kushal: 
Sorry, try again.
[sudo] password for kushal: 
hello

real	0m7.860s
user	0m0.081s
sys	0m0.057s
Wed Apr  5 06:09:30 AM EDT 2023
Looking for updates…

Nothing to do.

real	0m3.465s
user	0m0.274s
sys	0m0.111s
Wed Apr  5 06:09:34 AM EDT 2023
Copr repo for PyCharm owned by phracek                                                                                                                                                                         59 kB/s |  88 kB     00:01    
Fedora 37 - x86_64                                                                                                                                                                                            2.2 MB/s |  82 MB     00:37    
Fedora 37 openh264 (From Cisco) - x86_64                                                                                                                                                                      1.4 kB/s | 2.5 kB     00:01    
Fedora Modular 37 - x86_64                                                                                                                                                                                    1.5 MB/s | 3.8 MB     00:02    
Fedora 37 - x86_64 - Updates                                                                                                                                                                                  8.5 MB/s |  28 MB     00:03    
Fedora Modular 37 - x86_64 - Updates                                                                                                                                                                          1.6 MB/s | 3.0 MB     00:01    
google-chrome                                                                                                                                                                                                 4.1 kB/s | 3.6 kB     00:00    
RPM Fusion for Fedora 37 - Nonfree - NVIDIA Driver                                                                                                                                                             10 kB/s |  15 kB     00:01    
RPM Fusion for Fedora 37 - Nonfree - Steam                                                                                                                                                                    2.1 kB/s | 2.2 kB     00:01    
Dependencies resolved.
==============================================================================================================================================================================================================================================
 Package                                                            Architecture                                    Version                                                    Repository                                                Size
==============================================================================================================================================================================================================================================
Installing:
 kernel                                                             x86_64                                          6.2.9-200.fc37                                             updates                                                  128 k
 kernel-core                                                        x86_64                                          6.2.9-200.fc37                                             updates                                                   15 M
 kernel-modules                                                     x86_64                                          6.2.9-200.fc37                                             updates                                                   62 M
 kernel-modules-extra                                               x86_64                                          6.2.9-200.fc37                                             updates                                                  3.5 M
Upgrading:
 google-chrome-stable                                               x86_64                                          112.0.5615.49-1                                            google-chrome                                             91 M
 pycharm-community                                                  x86_64                                          2023.1-2.fc37                                              phracek-PyCharm                                          373 M
 pycharm-community-plugins                                          x86_64                                          2023.1-2.fc37                                              phracek-PyCharm                                           79 M
Installing dependencies:
 kernel-modules-core                                                x86_64                                          6.2.9-200.fc37                                             updates                                                   37 M
Removing:
 kernel                                                             x86_64                                          6.1.18-200.fc37                                            @updates                                                   0  
 kernel-core                                                        x86_64                                          6.1.18-200.fc37                                            @updates                                                  90 M
 kernel-modules                                                     x86_64                                          6.1.18-200.fc37                                            @updates                                                  57 M
 kernel-modules-extra                                               x86_64                                          6.1.18-200.fc37                                            @updates                                                 3.2 M

Transaction Summary
==============================================================================================================================================================================================================================================
Install  5 Packages
Upgrade  3 Packages
Remove   4 Packages

Total download size: 661 M
DNF will only download packages, install gpg keys, and check the transaction.
Downloading Packages:
(1/8): kernel-modules-extra-6.2.8-200.fc37_6.2.9-200.fc37.x86_64.drpm                                                                                                                                         1.5 MB/s | 2.7 MB     00:01    
(2/8): kernel-6.2.9-200.fc37.x86_64.rpm                                                                                                                                                                       286 kB/s | 128 kB     00:00    
/var/lib/dnf/system-upgrade/updates-fd4d3d0d1c34d49a/packages/kernel-modules-extra-6.2.8-200.fc37_6.2.9-200.fc37.x86_64.drpm: md5 mismatch of result                                                        ] 1.7 MB/s | 9.1 MB     06:06 ETA
(3/8): kernel-core-6.2.9-200.fc37.x86_64.rpm                                                                                                                                                                  406 kB/s |  15 MB     00:38    
(4/8): pycharm-community-2023.1-2.fc37.x86_64.rpm                                                                                                                                                              13 MB/s | 373 MB     00:28    
(5/8): pycharm-community-plugins-2023.1-2.fc37.x86_64.rpm                                                                                                                                                     5.0 MB/s |  79 MB     00:15    
(6/8): google-chrome-stable-112.0.5615.49-1.x86_64.rpm                                                                                                                                                         27 MB/s |  91 MB     00:03    
(7/8): kernel-modules-core-6.2.8-200.fc37_6.2.9-200.fc37.x86_64.drpm                                                                                                                                          196 kB/s |  28 MB     02:24    
/var/lib/dnf/system-upgrade/updates-fd4d3d0d1c34d49a/packages/kernel-modules-core-6.2.8-200.fc37_6.2.9-200.fc37.x86_64.drpm: md5 mismatch of result=====================================================-   ] 167 kB/s | 612 MB     02:16 ETA
(8/8): kernel-modules-6.2.8-200.fc37_6.2.9-200.fc37.x86_64.drpm                                                                                                                                               162 kB/s |  46 MB     04:50    
/var/lib/dnf/system-upgrade/updates-fd4d3d0d1c34d49a/packages/kernel-modules-6.2.8-200.fc37_6.2.9-200.fc37.x86_64.drpm: md5 mismatch of result
Some packages were not downloaded. Retrying.
(1/3): kernel-modules-extra-6.2.9-200.fc37.x86_64.rpm                                                                                                                                                         429 kB/s | 3.5 MB     00:08    
(2/3): kernel-modules-core-6.2.9-200.fc37.x86_64.rpm                                                                                                                                                          138 kB/s |  37 MB     04:34    
(3/3): kernel-modules-6.2.9-200.fc37.x86_64.rpm                                                                                                                                                               152 kB/s |  62 MB     06:59    
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Total                                                                                                                                                                                                         1.0 MB/s | 737 MB     12:28     
Failed Delta RPMs increased 661.0 MB of updates to 737.3 MB (10.3% wasted)
Running transaction check
Transaction check succeeded.
Running transaction test
Transaction test succeeded.
Complete!
Transaction saved to /var/lib/dnf/system-upgrade/system-upgrade-transaction.json.
Download complete! Use 'dnf offline-upgrade reboot' to start the upgrade.
To remove cached metadata and transaction use 'dnf offline-upgrade clean'
The downloaded packages were saved in cache until the next successful transaction.
You can remove cached packages by executing 'dnf clean packages'.

real	14m6.240s
user	1m55.121s
sys	0m7.434s
[sudo] password for kushal: 
sudo: timed out reading password
sudo: a password is required

real	5m2.043s
user	0m0.005s
sys	0m0.012s

```