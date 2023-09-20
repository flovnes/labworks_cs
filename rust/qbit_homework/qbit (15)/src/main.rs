use std::io;

fn main() {
    solution(input_values());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> u32 {
    input_line().trim().parse().unwrap()
}

fn solution(quantity: u32) {
    println!("{} {}", quantity*4990, scientific_from(quantity));
}

fn scientific_from(glasses: u32) -> String {

    let mut q = 249.5 * glasses as f32 / 3.;

    let mut clone_q = q.clone();
    let mut order_count: usize = 0;
    while clone_q >= 10. {
        order_count += 1;
        clone_q /= 10.;
    }

    q /= (10.0_f32).powf((order_count) as f32);
    format!("{:.3}e+{}",q,23+order_count)
}