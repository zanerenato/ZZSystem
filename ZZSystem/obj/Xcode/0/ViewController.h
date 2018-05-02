// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface ViewController : NSViewController {
	NSTextField *_PasswordText;
	NSTextField *_UserText;
}

@property (nonatomic, retain) IBOutlet NSTextField *PasswordText;

@property (nonatomic, retain) IBOutlet NSTextField *UserText;

- (IBAction)LoginButton:(id)sender;

- (IBAction)RegistrarButton:(id)sender;

@end
