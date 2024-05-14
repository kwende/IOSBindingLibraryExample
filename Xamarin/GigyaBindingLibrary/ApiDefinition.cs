using Foundation; 

namespace Poop
{
    // @interface SwiftFrameworkProxy : NSObject
    [BaseType(typeof(NSObject))]
    interface SwiftFrameworkProxy
    {
        // -(NSString * _Nonnull)initForApiKey:(NSString * _Nonnull)apiKey __attribute__((objc_method_family("none"))) __attribute__((warn_unused_result("")));
        [Export("initForApiKey:")]
        string InitForApiKey(string apiKey);
    }
}