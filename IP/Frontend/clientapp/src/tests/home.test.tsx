import { shallow } from "enzyme";
import Homepage from "../Pages/Home";

describe("HomePage", () => {
    let wrapper = shallow(<Homepage />);

    it("should render the homepage", () => {
        expect(wrapper.find(".homepage").first()).toBeDefined();
    });

    it("should render the navbar", () => {
        expect(wrapper.find(".navbar").first()).toBeDefined();
    });

    it("should render cards", () => {
        expect(wrapper.find(".homepage").first().find("cards").first()).toBeDefined();
    });
});
