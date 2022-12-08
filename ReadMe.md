# Devlog

## 2022.12.01

this repository is about making a basic game framework from scratch.

the first thing I came to mind is Service Locator Pattern. So I added a basic demo in this project, and will develop this framework based on this basic.

PS. I'm not a native English speaker. The reason why I'm writing in English is that I hope more people will participate in this dev activity. And please be free to point out my mistakes. Thx.

## 2022.12.02

I try to reduce the loss of performance when printing the log by Macro definition (`ENABLE_LOG`). And when I work with a subsystem, I think it's good to hide the log from other subsystem.

this is a advantage of service locator pattern.

About the scope of the code:

- Inherit: all of this is only one layer, handle services in parent class.
- MonoBehaviour: all unity component will be inherit, services is DI in the base class.

This means, we will locate the service in base class, and control the scope.

## 2022.12.06

This repository use git lfs(large file sotage) tracing assets of anims, materials, sounds and sprites.

Peforce P4V, or SVN, is commonly used in the game industry for version control. I think the reason is P4V is faster for large assets files, and all the co-operator can lock the file they current working at. so they don't need to deal with the conflict.

But this simple project is just developed by me alone. So I want to use git and git lfs this time. I must make sure the files less than 1G to use the online sotage, e.g. Github. or, maybe I will not upload the assets. but I think there is another way to publish them.
