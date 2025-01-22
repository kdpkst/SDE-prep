// the new syntax of defining a namespace is simpler, saving horizontal space and braces
namespace SampleNamespace;

class SampleClass {
    public void SampleMethod() {
        System.Console.WriteLine("SampleMethod inside SampleNamespace");
    }
}


// the same functionality as the following one

// namespace SampleNamespace {
//     class SampleClass {
//         public void SampleMethod() {
//             System.Console.WriteLine("SampleMethod inside SampleNamespace");
//         }
//     }
// }