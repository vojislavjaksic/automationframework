﻿Feature: Footer
	As a user
	I want to be able to wark with footer
	So I can interact with all the information

@mytag
Scenario Outline: User can open links under Infromation section
	When user clicks on '<information link>' option
	Then correct '<page>' is displayed
Examples: 
	| information link            | page                        |
	| Specials                    | Price drop                  |
	| New products                | New products                |
	| Best sellers                | Best sellers                |
	| Our stores                  | Our store(s)!               |
	| Contact us                  | Contact                     |
	| Terms and conditions of use | Terms and conditions of use |
	| About us                    | About us                    |
	| Sitemap                     | Sitemap                     |