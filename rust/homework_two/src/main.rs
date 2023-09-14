fn main() {
    // hii
}

fn _solution(point:(f32, f32)) -> &'static str {
    let condition_one = point.0.powf(2.) + point.1.powf(2.) <= 1.;              // x^2 + y^2 <= 1
    let condition_two = point.1 <= 0. && point.0 <= 0.;                         // x<=0 і y<=0
    let condition_three = (point.0-1.).powf(2.) + (point.1-1.).powf(2.) <= 1.;  // (x-1)^2 + (y-1)^2 <= 1
    
    if condition_one && condition_two {"YES"} 
    else if condition_one && condition_three {"YES"}
    else {"NO"}
}

#[test]
fn tests() {
    //axis
    assert_eq!(_solution((-1.,0.)), "YES");
    assert_eq!(_solution((0.,-1.)), "YES");
    assert_eq!(_solution((0.,1.)), "YES");
    assert_eq!(_solution((1.,0.)), "YES");
    //internal
    assert_eq!(_solution((-0.5,-0.5)), "YES");
    assert_eq!(_solution((0.5,0.5)), "YES");
    //corners
    assert_eq!(_solution((-1.,-1.)), "NO");
    assert_eq!(_solution((1.,1.)), "NO");
}