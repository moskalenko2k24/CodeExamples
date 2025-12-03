public class ArrayExample {
	public static void main(String[] args) {
		final String delimeter = "---------------";
		String[] languages = {"C++", "C#", "Java", "Kotlin", "Rust"};
		for (int i = languages.length - 1; i >= 0; i--) {
			System.out.println(languages[i]);
		}
		System.out.println(delimeter);
		for (String language: languages) {
			System.out.println(language);
		}
		System.out.println(delimeter);
		int[] a = new int[10];
		for (int i = 0; i < a.length; i++) {
			a[i] = 1 << i;
		}
		for (int num: a) {
			System.out.print(num + " ");
		}
	}
}
